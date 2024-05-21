using Conciliador.Modelos.DTOs;


namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IEmpresaService
    {
        Task<Boolean>Add(EmpresaDto entity);
        Task<Boolean>Update(EmpresaDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<EmpresaDto>>GetAll();
        Task<EmpresaDto>GetById(Int32 id);
        Task<List<EmpresaDto>>GetByStatus(Boolean status);
    }
}
