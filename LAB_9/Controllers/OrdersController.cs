using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab10.Data;
using lab10.Models;

namespace lab10.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Order.Include(o => o.customer).Include(o => o.product);
            return View(await _context.Order.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.customer)
                .Include(o => o.product)
                .FirstOrDefaultAsync(m => m.Order_ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["Cust_ID"] = new SelectList(_context.Customer, "Cust_ID", "Cust_ID");
            ViewData["P_ID"] = new SelectList(_context.Product, "P_ID", "P_ID");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Order_ID,Cust_ID,P_ID,Amount,Order_DateTime")] Order order)
        {
            if (ModelState.IsValid)
            {
                Order o = order;
                Product p = new Product();
                double price = _context.Product.Where(P => P.P_ID== order.P_ID).Select(P => P.Price).FirstOrDefault();

                o.P_ID = order.P_ID;
                o.Cust_ID = order.Cust_ID;
                o.Amount = price;
                o.Order_DateTime = order.Order_DateTime;
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
              
            }
            ViewData["Cust_ID"] = new SelectList(_context.Customer, "Cust_ID", "Cust_ID", order.Cust_ID);
            ViewData["P_ID"] = new SelectList(_context.Product, "P_ID", "P_ID", order.P_ID);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["Cust_ID"] = new SelectList(_context.Customer, "Cust_ID", "Cust_ID", order.Cust_ID);
            ViewData["P_ID"] = new SelectList(_context.Product, "P_ID", "P_ID", order.P_ID);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Order_ID,Cust_ID,P_ID,Amount,Order_DateTime")] Order order)
        {
            if (id != order.Order_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Order_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cust_ID"] = new SelectList(_context.Customer, "Cust_ID", "Cust_ID", order.Cust_ID);
            ViewData["P_ID"] = new SelectList(_context.Product, "P_ID", "P_ID", order.P_ID);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                 .Include(o => o.customer)
                 .Include(o => o.product)
                 .FirstOrDefaultAsync(m => m.Order_ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.Order_ID == id);
        }
    }
}