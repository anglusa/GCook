using GCook.ViewModels;

namespace GCook.Services;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogado();        
}
