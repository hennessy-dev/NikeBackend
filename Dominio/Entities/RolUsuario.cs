namespace Dominio.Entities;
public class UserRol
{
    public int IdRolFk { get; set; }
    public Rol Rol { get; set; }
    public int IdUsuarioFk { get; set; }
    public User User { get; set; }
}