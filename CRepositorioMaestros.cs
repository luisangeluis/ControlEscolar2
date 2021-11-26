using System;
using System.Collections.Generic;

public class CRepositorioMaestros:IRepositorio{

  private List<CMaestro> Maestros = null;

  public CRepositorioMaestros(){
    Maestros = new List<CMaestro>();
    
    CMaestro maestro1 = new CMaestro("0000","Mario",40);
    Maestros.Add(maestro1);
  }  

  public void MostrarPersonas(){
    
  }

  public int BuscarPersona(string pCodigo){
    return 0;
  }

  public bool AgregarPersona(CAlumno pAlumno){
    return false;
  }

  public bool EliminarPersona(string pCodigo){
    return false;
  }
  
  public bool ModificarPersona(string pCodigo){
    return false;
  }

  public void BuscarPersonaByCodigo(string pCodigo){
    
  }

}