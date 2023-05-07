using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        //Cria os objetos para popular o banco de dados.
        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Arlindo Ventura", "ventura@email.com", new DateTime(1998, 4, 21), 1300.00, d1);
            Seller s2 = new Seller(2, "Crisvaldo Campos", "cri@email.com", new DateTime(1996, 6, 10), 1340.00, d3);
            Seller s3 = new Seller(3, "Benedita Muller", "bene@email.com", new DateTime(1997, 10, 10), 1340.00, d3);
            Seller s4 = new Seller(4, "Ana Sofi", "ana@email.com", new DateTime(1995, 7, 10), 1340.00, d4);
            Seller s5 = new Seller(5, "Mateus Silva", "mateus@email.com", new DateTime(1995, 2, 28), 1310.00, d1);
            Seller s6 = new Seller(6, "Alex Teixeira", "alex@email.com", new DateTime(1996, 1, 15), 1310.00, d2);
            Seller s7 = new Seller(7, "Vivian Miranda", "vivian@email.com", new DateTime(1995, 6, 6), 1300.00, d4);
            Seller s8 = new Seller(8, "Priscila Cunha", "pri@email.com", new DateTime(1993, 6, 1), 1600.00, d1);
            Seller s9 = new Seller(9, "Alírio Santos", "alirio93@email.com", new DateTime(1994, 12, 9), 1300.00, d2);
            Seller s10 = new Seller(10, "Agata Correa", "agata95@email.com", new DateTime(1995, 3, 2), 1300.00, d2);


            SalesRecord r1 = new SalesRecord(1, new DateTime(DateTime.Now.Year, 09, 25), 11000.0, SaleStatus.Billed, s8);
            SalesRecord r2 = new SalesRecord(2, new DateTime(DateTime.Now.Year, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(DateTime.Now.Year, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(DateTime.Now.Year, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(DateTime.Now.Year, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(DateTime.Now.Year, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(DateTime.Now.Year, 09, 28), 13000.0, SaleStatus.Billed, s8);
            SalesRecord r8 = new SalesRecord(8, new DateTime(DateTime.Now.Year, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(DateTime.Now.Year, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(DateTime.Now.Year, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(DateTime.Now.Year, 09, 13), 6000.0, SaleStatus.Billed, s8);
            SalesRecord r12 = new SalesRecord(12, new DateTime(DateTime.Now.Year, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(DateTime.Now.Year, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(DateTime.Now.Year, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(DateTime.Now.Year, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(DateTime.Now.Year, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(DateTime.Now.Year, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(DateTime.Now.Year, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(DateTime.Now.Year, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(DateTime.Now.Year, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(DateTime.Now.Year, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(DateTime.Now.Year, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(DateTime.Now.Year, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(DateTime.Now.Year, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(DateTime.Now.Year, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(DateTime.Now.Year, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(DateTime.Now.Year, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(DateTime.Now.Year, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(DateTime.Now.Year, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(DateTime.Now.Year, 10, 12), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r31 = new SalesRecord(31, new DateTime(DateTime.Now.Year, 10, 17), 9000.0, SaleStatus.Billed, s7);
            SalesRecord r32 = new SalesRecord(32, new DateTime(DateTime.Now.Year, 10, 24), 4000.0, SaleStatus.Billed, s8);
            SalesRecord r33 = new SalesRecord(33, new DateTime(DateTime.Now.Year, 10, 19), 11000.0, SaleStatus.Canceled, s9);
            SalesRecord r34 = new SalesRecord(34, new DateTime(DateTime.Now.Year, 10, 12), 8000.0, SaleStatus.Billed, s10);
            SalesRecord r35 = new SalesRecord(35, new DateTime(DateTime.Now.Year, 10, 31), 7000.0, SaleStatus.Billed, s7);
            SalesRecord r36 = new SalesRecord(36, new DateTime(DateTime.Now.Year, 10, 6), 5000.0, SaleStatus.Billed, s8);
            SalesRecord r37 = new SalesRecord(37, new DateTime(DateTime.Now.Year, 10, 13), 9000.0, SaleStatus.Pending, s9);
            SalesRecord r38 = new SalesRecord(38, new DateTime(DateTime.Now.Year, 10, 7), 4000.0, SaleStatus.Billed, s10);
            SalesRecord r39 = new SalesRecord(39, new DateTime(DateTime.Now.Year, 10, 23), 12000.0, SaleStatus.Billed, s8);
            SalesRecord r40 = new SalesRecord(40, new DateTime(DateTime.Now.Year, 10, 12), 5000.0, SaleStatus.Billed, s8);
            SalesRecord r41 = new SalesRecord(41, new DateTime(DateTime.Now.Year, 10, 12), 5000.0, SaleStatus.Billed, s8);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            _context.SalesRecord.AddRange(
               r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
               r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
               r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
               r31, r32, r33, r34, r35, r36, r37, r38, r39, r40
           );
            _context.SaveChanges();

        }
    }
}
