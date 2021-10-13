public class CPerson{
  
  public string Codigo {set;get;}
  public string Nombre{set;get;}
  public int Edad{set;get;}
  
  public CPerson(string pCodigo,string pNombre,int pEdad){
    Codigo = pCodigo;
    Nombre =pNombre;
    Edad = pEdad;
  }

  public override string ToString(){
    return string.Format("Codigo {0} Nombre: {1} Edad {2} ",Codigo,Nombre,Edad);
  }
}