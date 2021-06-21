using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private readonly SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
             if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // O Banco de Dados já foi populado
            } 
             
             /* 
              
            Department d1 = new Department(0,"Computers");
            Department d2 = new Department(0, "Electronics");
            Department d3 = new Department(0, "Fashion");
            Department d4 = new Department(0, "Books");

            Seller s1 = new Seller( 0,"Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller( 0, "Maria Green", "maria@gmail.com", new DateTime(1979, 5, 31), 1000.0, d2);
            Seller s3 = new Seller( 0, "Alex Grey", "alex@gmail.com", new DateTime(1998, 1, 15), 1000.0, d1);
            Seller s4 = new Seller( 0, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 1000.0, d4);
            Seller s5 = new Seller( 0, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 1000.0, d3);
            Seller s6 = new Seller( 0, "Alex Pink", "alexpink@gmail.com", new DateTime(1997, 3, 4), 1000.0, d2);

            SalesRecord r1 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(0, new DateTime(2019, 09, 25), 13000.0, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(0, new DateTime(2020, 10, 25), 10000.0, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(0, new DateTime(2021, 01, 25), 15000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(0, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Canceled, s5);
            SalesRecord r6 = new SalesRecord(0, new DateTime(2020, 12, 25), 18000.0, SaleStatus.Pending, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6);

            _context.SaveChanges();
             */
        }
    }
}
