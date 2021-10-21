using System;
using System.Collections.Generic;

public class CRepositorioAlumno{

  private List<CAlumno> Alumnos = null;
  
  public CRepositorioAlumno(){
    Alumnos = new List<CAlumno>();
    CAlumno alumno1 = new CAlumno("0000","luis",30);
    Alumnos.Add(alumno1);
  }
  //BUSCAR PERSONA
  public int BuscarPersona(string pCodigo){
    int posicion = -1;

    if(Alumnos!=null){
       for(int i=0; i<Alumnos.Count;i++){
          if(pCodigo == Alumnos[i].Codigo)
            posicion = i;
       } 
    }

    return posicion;
  }
  //AGREGAR PERSONA
  public bool AgregarPersona(CAlumno pAlumno){
    if(pAlumno !=null){

      int posicion = BuscarPersona(pAlumno.Codigo);
      
      if(posicion<0){
        Alumnos.Add(pAlumno);
        return true;
      }

    }

    return false;
  }
  //ELIMINAR PERSONA
  public bool EliminarPersona(string pCodigo){
    int posicion = BuscarPersona(pCodigo);
    
    if(posicion>=0){
      Alumnos.RemoveAt(posicion);
      return true;
    }
    
    return false;
  }
  //MODIFICAR PERSONA
  public bool ModificarPersona(string pCodigo){
    int posicion = BuscarPersona(pCodigo);

    if(posicion>=0){

      int opcion = 0;

      Console.WriteLine("INGRESE UNA OPCION");
      Console.WriteLine("1.-UNO PARA CODIGO");
      Console.WriteLine("2.-DOS PARA NOMBRE");
      Console.WriteLine("3.-TRES PARA EDAD");
      try{
        opcion = Convert.ToInt32(Console.ReadLine());

      }catch(Exception e){
        Console.WriteLine(e);
      }

      switch(opcion){
        case 1:
          string codigo="";

          Console.WriteLine("Ingresa el nuevo codigo");
          try{
            codigo = Console.ReadLine();

          }catch(Exception e){
            Console.WriteLine(e);
          }
          if(codigo !="")
            Alumnos[posicion].Codigo = codigo;
        break;
      }
      
    }
    return false;
  }
}
