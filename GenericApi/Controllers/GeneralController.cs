using GenericApi.Models;
using GenericApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GenericApi.Controllers;

[Route("api/[controller]/[action]")]
public class GeneralController : Controller
{
    [HttpPost]
    public IActionResult addUser(User user)
    {
        var userRepository = new UserRepositoryImpl();
        return Ok(userRepository.add(user));
    }
    
    [HttpPost]
    public IActionResult addAdmin(Admin admin)
    {
        var adminRepo = new AdminRepositoryimpl();
        return Ok(adminRepo.add(admin));
    }

    [HttpGet]
    public IActionResult getUser(int id)
    {
        var userRepo = new UserRepositoryImpl();
        return Ok(userRepo.getById(id));
    }
    
    [HttpGet]
    public IActionResult getAdmin(int id)
    {
        var adminRepo = new AdminRepositoryimpl();
        return Ok(adminRepo.getById(id));
    }
    
    
}