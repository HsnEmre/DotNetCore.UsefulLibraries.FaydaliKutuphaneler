using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FluentValidation.App.Models;
using FluentValidation;
using AutoMapper;
using FluentValidation.App.DTO;

[Route("api/[controller]")]
[ApiController]
public class CustomersAPIController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IValidator<Customer> _cstomerValidator;
    private readonly IMapper _mapper;



    [Route("mappingexample")]
    [HttpGet]
    public IActionResult MappingExampler()
    {

        Customer custome = new Customer
        {
            Id = 1,
            Name = "Hasan",
            Mail = "asd@gmail.com",
            Age = 27
        };



        return Ok(_mapper.Map<CustomerDto>(custome));

    }





    public CustomersAPIController(AppDbContext context
        , IValidator<Customer> ct
        ,IMapper mapper)
    {
        _context = context;
        _cstomerValidator = ct;
        _mapper = mapper;
    }

    // GET: api/Customer
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
    {
        var customers = await _context.Customer.ToListAsync();
        var customerDtos = _mapper.Map<List<CustomerDto>>(customers);

        return Ok(customerDtos);
    }

    // GET: api/Customer/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Customer>> GetCustomer(int id)
    {
        var customer = await _context.Customer.FindAsync(id);

        if (customer == null)
        {
            return NotFound();
        }

        return customer;
    }

    // PUT: api/Customer/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCustomer(int? id, Customer customer)
    {
        if (id != customer.Id)
        {
            return BadRequest();
        }

        _context.Entry(customer).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CustomerExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }





    // POST: api/Customer
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
    {
        //api tarafında modelstate olayı yok

        var result = _cstomerValidator.Validate(customer);
        if (!result.IsValid)
        {
            return BadRequest(result.Errors.Select(x => new
            {

                property = x.PropertyName,
                error = x.ErrorMessage
            }));
        }


        _context.Customer.Add(customer);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
    }

    // DELETE: api/Customer/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCustomer(int? id)
    {
        var customer = await _context.Customer.FindAsync(id);
        if (customer == null)
        {
            return NotFound();
        }

        _context.Customer.Remove(customer);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool CustomerExists(int? id)
    {
        return _context.Customer.Any(e => e.Id == id);
    }
}
