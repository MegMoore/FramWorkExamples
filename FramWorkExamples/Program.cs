
using FramWorkExamples;


var _context = new AppDbContext();
var customers = from c in _context.Customers  //query syntax
                select c;

foreach(var cust in customers)
{
    Console.WriteLine(cust);
}