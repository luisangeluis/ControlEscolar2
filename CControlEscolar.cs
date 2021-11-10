using System.Collections.Generic;
using System;

public class CControlEscolar{

 CRepositorioAlumno Alumnos = new CRepositorioAlumno();
  
  // public void GetAlumnoByIndice(int pIndice){
  //   Console.WriteLine(Alumnos[pIndice]);
  // }
  public void MainMenu(){

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
          BuscarAlumno();

        if(opcionAlumnos == 2){

          if(AgregarAlumno())
            Console.WriteLine("alumno agregado");
          else
            Console.WriteLine("alumno ya existe");
        }
      break;
      case 2:
      break;
    }
    
  }
  //BUSCAR PERSONA
  public void BuscarAlumno(){
    int posicion = -1;
    string codigo ="";

    Console.WriteLine("Ingrese codigo del alumno");
    codigo = Console.ReadLine();

    posicion = Alumnos.BuscarPersona(codigo);

    if(posicion >= 0)
      Console.WriteLine(Alumnos[posicion]);
  }
  //AGREGAR ALUMNO
  public bool AgregarAlumno(){
    int posicion = -1;
    string codigo="";
    string nombre="";
    int edad =0;
    bool alumnoAgregado=false;
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
      alumnoAgregado = Alumnos.AgregarPersona(alumno);
    }  
    return alumnoAgregado;
  }
  //MENU PRINCIPAL
  public void MainMenuAlumnos(){

    Console.WriteLine("Menu alumnos");
    Console.WriteLine("1.- Uno para buscar alumno");
    Console.WriteLine("2.- Dos agregar alumno");
    Console.WriteLine("3.- Tres para borrar alumno");
    Console.WriteLine("4.- Cuatro para modificar alumno");
    Console.WriteLine("5.- Cinco para salir");

  }
}