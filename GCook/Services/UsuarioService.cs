using GCook.Data;
using GCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GCook.Services;
public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _context;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly  IHttpContextAccessor  _httpContextAcessor;


    public UsuarioService(
        AppDbContext context, 
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager,
        IHttpContextAccessor httpContextAcessor
    )
    {
        _context = context;
        _signInManager = signInManager;
        _userManager = userManager;
        _httpContextAcessor = httpContextAcessor;
    }
    public Task<UsuarioVM> GetUsuarioLogado()
    {
        throw new NotImplementedException();
    }
}
