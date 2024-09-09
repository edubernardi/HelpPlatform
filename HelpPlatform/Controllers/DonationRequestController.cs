using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpPlatform.Data;
using HelpPlatform.Models;

namespace HelpPlatform.Controllers;

[Route("donationrequests")]
[ApiController]
public class DonationRequestController : Controller
{
    private readonly BlazorDbContext _db;

    public DonationRequestController(BlazorDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<DonationRequest>>> GetRequests()
    {
        return (await _db.DonationRequests.ToListAsync()).ToList();
    }
}
