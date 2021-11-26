using System.Collections.Generic;
using System;

public class CControlEscolar{

  IRepositorio Personas = new CRepositorioAlumno();
  
  // public void GetAlumnoByIndice(int pIndice){
  //   Console.WriteLine(Alumnos[pIndice]);
  // }
  public void MainMenu(){

    while(true){

      string opcion = "";
      int valor = 0;
    
      Console.WriteLine("Control Escolar");
      Console.WriteLine("1.-Uno para alumnos");
      Console.WriteLine("2.-Dos para maestros");
      Console.WriteLine("3.- Tres para salir");
    
      Console.WriteLine("Ingrese una opcion");
      opcion = Console.ReadLine();
      valor = Convert.ToInt32(opcion);


      switch(valor){
        case 1:

          int opcionAlumnos = 0;
        
          MainMenuAlumnos();
          opcionAlumnos = Convert.ToInt32(Console.ReadLine());

          if(opcionAlumnos == 1)
            BuscarPersonaByCodigo();

          if(opcionAlumnos == 2){

            if(AgregarPersona())
              Console.WriteLine("Persona agregada");
            else
              Console.WriteLine("Persona ya existe");
          }
          if(opcionAlumnos==3){
            if(BorrarPersona())
              Console.WriteLine("Persona borrada");
            else
              Console.WriteLine("Persona no encontrada");

          } 
          if(opcionAlumnos==4){
            if(ModificarPersona())
              Console.WriteLine("Persona modificada");
            else
              Console.WriteLine("Persona no modificado");

          }
          if(opcionAlumnos==5){
            MostrarPersonas();
          }
        
        break;
        case 2:
        Personas = new CRepositorioMaestros();
        break;
      }
      
      Console.WriteLine("Desea continuar s para si n para n");
      if(Console.ReadLine() == "n")
        break;
    }
  }
    
  //MENU PRINCIPAL ALUMNOS
  public void MainMenuAlumnos(){

    Console.WriteLine("Menu alumnos");
    Console.WriteLine("1.- Uno para buscar alumno");
    Console.WriteLine("2.- Dos agregar alumno");
    Console.WriteLine("3.- Tres para borrar alumno");
    Console.WriteLine("4.- Cuatro para modificar alumno");
    Console.WriteLine("5.- Cinco para ver alumnos");
    Console.WriteLine("6.- Seis para salir");

  }
  //MOSTRAR PERSONA
  public void MostrarPersonas(){
    Personas.MostrarPersonas();
  }
  //BUSCAR PERSONA
  /*
  public void BuscarPersona(){
    //int posicion = -1;
    string codigo ="";

    Console.WriteLine("Ingrese codigo de la persona");
    codigo = Console.ReadLine();

    //posicion = Personas.BuscarPersona(codigo);
    Personas.BuscarPersona(codigo);
    /*
    if(posicion >= 0)
      Console.WriteLine(Personas[posicion]);
    else
      Console.WriteLine("Persona no existe");
    
  }*/

  //Buscar persona por codigo
  public void BuscarPersonaByCodigo(){
    string codigo;
    Console.WriteLine("Ingrese el codigo de la persona");
    codigo = Console.ReadLine();

    Personas.BuscarPersonaByCodigo(codigo);
  }

  //AGREGAR ALUMNO
  public bool AgregarPersona(){
    //int posicion = -1;
    string codigo="";
    string nombre="" ;
    int edad =0;
    bool PersonaAgregada=false;
    CAlumno alumno =null;

    try{
      Console.WriteLine("Ingrese el codigo del alumno");
      codigo = Console.ReadLine();
    
      Console.WriteLine("Ingrese el nombre de la persona");
      nombre = Console.ReadLine();

      Console.WriteLine("Ingrese la edad de la persona");
      edad = Convert.ToInt32(Console.ReadLine());

      alumno = new CAlumno(codigo,nombre,edad);
    }catch(Exception e){

    }

    if(alumno !=null){
      PersonaAgregada = Personas.AgregarPersona(alumno);
    }  
    return PersonaAgregada;
  }
  //Metodo para borrar alumno

  public bool BorrarPersona(){
    bool borrarPersona = false;
    string codigo ="";
    
    try{
      Console.WriteLine("Ingrese el codigo de la Persona");
      codigo = Console.ReadLine();

      borrarPersona = Personas.EliminarPersona(codigo);
    }catch(Exception e){

    }
    
    return borrarPersona;
  }
  //Modificar alumno
  public bool ModificarPersona(){
    bool modificarPersona = true;
    string codigo ="";
    try{
      Console.WriteLine("Ingrese codigo de la persona");
      codigo = Console.ReadLine();

      modificarPersona = Personas.ModificarPersona(codigo);
    }catch(Exception e){

    }
    
    return modificarPersona;
  }
  
}