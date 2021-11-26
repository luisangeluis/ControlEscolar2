public class CMateria{
  public string Codigo {set;get;}
  public string Nombre {set;get;}

  public CMateria(string pCodigo,string pNombre){
    Codigo = pCodigo;
    Nombre = pNombre;
  }
  public override string ToString(){
    return string.Format("Codigo = {0} Nombre = {1}",Codigo,Nombre);
  }
}