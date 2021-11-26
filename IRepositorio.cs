public interface IRepositorio{
  void MostrarPersonas();
  int BuscarPersona(string pCodigo);
  bool AgregarPersona(CAlumno pAlumno);
  bool EliminarPersona(string pCodigo);
  bool ModificarPersona(string pCodigo);
  void BuscarPersonaByCodigo(string pCodigo); 
}