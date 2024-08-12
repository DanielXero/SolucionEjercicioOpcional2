
int numOpcion = 0;
Random random = new Random();


do
{


    Console.WriteLine("\t\t***** Resolución Ejercicio Opcional 2 *****\n\n");
    for (int i = 1; i <= 8; i++)
    {
        if (i == 6)
        {
            Console.WriteLine($"{i}. Resolución Ejercicio {i} (No finalizado)");
        }
        else
        {
            Console.WriteLine($"{i}. Resolución Ejercicio {i}");
        }
        
    }
    Console.WriteLine("0. Salir");

    do
    {
        numOpcion = GetIntegerDataFromUser("Elige una opcion (1-8): ");

    } while (numOpcion < 0 || numOpcion > 8);

    switch(numOpcion)
    {
        case 1:
            Console.Clear();
            ResoluciónEjercicio1();
            break;
        case 2:
            Console.Clear();
            ResoluciónEjercicio2();
            break;
        case 3:
            Console.Clear();
            ResoluciónEjercicio3();
            break;
        case 4:
            Console.Clear();
            ResoluciónEjercicio4();
            break;
        case 5:
            Console.Clear();
            ResoluciónEjercicio5();
            break;
        case 6:
            Console.Clear();
            ResoluciónEjercicio6();
            break;
        case 7:
            Console.Clear();
            ResoluciónEjercicio7();
            break;
        case 8:
            Console.Clear();
            ResoluciónEjercicio8();
            break;
    }

    Console.Write("\n\nPresione una tecla para continuar");
    Console.ReadLine();


    if (numOpcion == 0)
    {
        Console.WriteLine("\n\nPrograma finalizado.");
    } else
    {
        Console.Clear();
    }

} while (numOpcion != 0);


/*
 * Dado que se tiene almacenado en una lista, los resultados de los últimos 10 exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de los exámenes y el promedio resultante.
*/

void ResoluciónEjercicio1()
{
    double[] notas = new double[10];
    double promedioNotas = 0.0, acumNotas = 0.0;


    for (int i = 0; i < 10; i++)
    {
        notas[i] = Math.Round(random.NextDouble() * (random.Next(0, 11)), 2);
        acumNotas += notas[i];
    }

    promedioNotas = Math.Round(acumNotas / 10.0, 2);
    Console.WriteLine("Las 10 notas de los útimos examen son: ");
    foreach (var nota in notas)
    {
        Console.Write($"{nota} ");
    }

    Console.WriteLine($"\nEl promedio notas de los últimos 10 examenes es: {promedioNotas}");
}



/*
 * Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla cuántos son mayores de edad y cuántos no.
 */
void ResoluciónEjercicio2()
{
    List<int> edades = new List<int>();
    int contMax = 0, contMin = 0;


    for (int i = 0; i < 20; i++)
    {
        edades.Add(random.Next(1, 45));
        
    }


    for (int i = 0; i < 20; i++)
    {
        if (edades[i] >= 18)
        {
            contMax++;
        } else
        {
            contMin++;
        }  

    }


    Console.WriteLine("Lista de edades de 20 personas: ");
    foreach (var edad in edades)
    {
        Console.Write($"{edad}, ");
    }


    Console.WriteLine("\b\b.\n");
    Console.WriteLine($"La cantidad de personas mayores de edad son {contMax} y la cantidad de personas menores de edad son {contMin}");

}


/*
 * Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que tenga menos letras de todos.
 */
void ResoluciónEjercicio3()
{

    string[] nombresEstudiantes = { "Juan", "Ana", "Luis", "Carlos", "Valentina", "Elena", "Sara", "Daniel", "Pablo", "Dari" };
    string minLetraNombre = nombresEstudiantes[0], maxLetraNombre = nombresEstudiantes[0];
    for (int i = 0; i < nombresEstudiantes.Length; i++)
    {
        if (nombresEstudiantes[i].Length > maxLetraNombre.Length)
        {
            maxLetraNombre = nombresEstudiantes[i];
        } else if (nombresEstudiantes[i].Length < minLetraNombre.Length)
        {
            minLetraNombre = nombresEstudiantes[i];
        }

    }
    Console.WriteLine("Lista de Nombres: ");
    foreach (var nombre in nombresEstudiantes)
    {
        Console.WriteLine(nombre);
    }

    Console.WriteLine($"\n\nEl nombre que tiene mayor cantidad de letras es: {maxLetraNombre}");
    Console.WriteLine($"\n\nEl nombre que tiene menor cantidad de letras es: {minLetraNombre}");
}


/*
 * Crear una variable para guardar los nombres de elementos para una “lista de supermercado”. 
 * Solicitar al usuario que ingrese el nombre de un elemento que va a comprar en el super y verificar que el elemento esté en la lista. 
 * Si no está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. 
 * Al finalizar mostrar por pantalla los elementos que no compró y los que compró, pero no estaban en la lista. 
 * Si se quiere, mostrar también todos los elementos que el usuario compró. Para salir el usuario debe ingresar “fin”.
*/


void ResoluciónEjercicio4()
{
    List<string> listaProductos = new List<string>()
    {
        // Frutas y verduras
        "frutilla", "banana", "naranja", "pera", "uva", "tomate", "pepino", "lechuga", "zanahoria", "mandarina",
        // Lácteos
        "leche", "yogurt", "queso", "mantequilla", "crema",
        // Carnes
        "carne vacuna", "carne de pollo", "carne de cerdo",
        // Granos y cereales
        "arroz", "fideos", "pan", "avena",
        // Limpieza
        "detergente", "jabón", "papel higiénico",
        // Otros
        "agua mineral", "gaseosa", "café", "té"
    };

    List<string> listaProductosComprados = new List<string>();    
    List<string> listaProductos2 = new List<string>();

    string respuesta, producto;
    bool existe = false;

    do
    {
        Console.WriteLine("\t\t***** El super del oeste *****\n\n");
        Console.Write("Ingrese el nombre del producto que desea comprar: ");
        producto = Console.ReadLine().ToLower();

        existe = listaProductos.Contains(producto);
        if (existe)
        {
            Console.WriteLine("Sí, tenemos ese producto en existencia.");
            listaProductos.Remove(producto);
            listaProductosComprados.Add(producto);
        }
        else
        {
            Console.WriteLine("No, tenemos ese producto en existencia.");
            listaProductos.Add(producto);
            listaProductos2.Add(producto);

        }

        Console.Write("Desea seguir comprando en el sumpercado ('fin' -> para finalizar)?: ");
        respuesta = Console.ReadLine().ToLower();

        if (!respuesta.Equals("fin")) 
        
        {
            Console.Clear();
        }

    } while (!respuesta.Equals("fin"));


    Console.WriteLine("Lista de productos no comprados:");
    foreach (var item in listaProductos)
    {
        Console.WriteLine($"{item}.");
    }

    Console.WriteLine("\n\nLista de productos que se compro pero no estaban en la lista: ");
    foreach (var item in listaProductos2)
    {
        Console.WriteLine($"{item}.");
    }

    listaProductosComprados.AddRange(listaProductos2);

    Console.WriteLine("\n\nLista de productos comprados: ");
    foreach (var item in listaProductosComprados)
    {
        Console.WriteLine($"{item}.");
    }

  

}

/*
 * Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares pares. Imprimir la matriz por pantalla.
 */

void ResoluciónEjercicio5()
{
    char[,] matriz = new char[5, 5];
    int auxCont = 1;

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (auxCont % 2 == 0)
            {
                matriz[i, j] = 'P';
            } else
            {
                matriz[i, j] = 'I';
            }
            auxCont++;
        }
    }


    Console.WriteLine("\t\t***** Matiz 5x5 *****\n\n");


    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write($"{matriz[i,j]} ");
        }
        Console.WriteLine();
    }

}

/*
 * Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de la semana. 
 * La estructura es para registrar la temperatura diaria de una cabina de pago, estos oscilan entre los 7 y 38 grados. 
 * Deberá llenar la matriz de forma aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) 
 * se ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el principio del programa, 
 * no es necesario pedir los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
        Obtener la temperatura más alta y baja de la semana y que día se produjo (lunes, martes, etc.)
        Promedio de temperatura de la semana.
        Temperatura más alta del mes y su día.
*/

void ResoluciónEjercicio6()
{
    bool isFinalizado = false;
    if (!isFinalizado)
    {
        Console.WriteLine("El ejercicio no finalizado");
    } else
    {
        int[,] temperaturasMes = new int[5, 7];
        int[,] matrizMes = new int[5, 7];
        int contDias = 1, minTemp, maxTemp, posMax = 0, posMin = 0;
        int tempAleatoria;

        int acumTemperaturas = 0, maxTempMes = 0, posMaxMes = 0;


        List<int> posMaximas = new List<int>();
        List<int> posMinimas = new List<int>();
        List<int> tempMaximas = new List<int>();
        List<int> tempMinimas = new List<int>();
        List<double> promTemperaturas = new List<double>();

        for (int i = 0; i < temperaturasMes.GetLength(0); i++)
        {
            for (int j = 0; j < temperaturasMes.GetLength(1); j++)
            {

                if (contDias <= 31)
                {
                    matrizMes[i, j] = contDias;

                    temperaturasMes[i, j] = random.Next(7, 39);

                }
                contDias++;

            }
        }


        mostrarCalendario(matrizMes, "Calendario");
        Console.WriteLine("\n\n");
        mostrarCalendario(temperaturasMes, "Temperatura");
        Console.WriteLine("\n\n");



        maxTemp = temperaturasMes[0, 0];
        minTemp = temperaturasMes[0, 0];
        contDias = 0;
        for (int i = 0; i < temperaturasMes.GetLength(0); i++)
        {

            acumTemperaturas = 0;

            for (int j = 0; j < temperaturasMes.GetLength(1); j++)
            {
                if (contDias % 7 == 0)
                {
                    maxTemp = temperaturasMes[i + 1, j + 1];
                }

                if (contDias <= 31 && maxTemp < temperaturasMes[i, j])
                {

                    maxTemp = temperaturasMes[i, j];
                    posMax = contDias;


                }
                else if (contDias <= 31 && minTemp > temperaturasMes[i, j])
                {

                    minTemp = temperaturasMes[i, j];
                    posMin = contDias;

                }
                contDias++;

                acumTemperaturas += temperaturasMes[i, j];

            }
            Console.WriteLine(posMax);
            maxTempMes = maxTemp;
            posMaxMes = posMax;

            promTemperaturas.Add(Math.Round(acumTemperaturas / 7.0, 2));
            tempMaximas.Add(maxTemp);
            tempMinimas.Add(minTemp);
            posMaximas.Add(posMax);
            posMinimas.Add(posMin);


        }


        Console.WriteLine();

        for (int i = 0; i < tempMaximas.Count; i++)
        {
            Console.WriteLine($"Semana {i + 1}:");



            Console.WriteLine($"La temperatura más alta en está semana fue {tempMaximas[i]}°C y se produjo en el día {ObtenerDia(posMaximas[i] + 1)}");
            Console.WriteLine($"La temperatura más baja en está semana fue {tempMinimas[i]}°C y se produjo en el día {ObtenerDia(posMinimas[i] + 1)}");
            Console.WriteLine($"La temperatura promedio de la semana es: {promTemperaturas[i]}°C");

        }

        Console.WriteLine($"La temperatura máxima del mes fue {maxTempMes}°C y se produjo en el día {ObtenerDia(posMaxMes)}");
    }

}

string ObtenerDia(int posiciones)
{
    string msgDia = "";
    switch (posiciones)
    {
        case 1: case 8: case 15: case 22: case 29:
            msgDia = "Lunes";
            break;
        case 2: case 9: case 16: case 23: case 30:
            msgDia = "Martes";
            break;
        case 3: case 10: case 17: case 24: case 31:
            msgDia = "Miercoles";
            break;
        case 4: case 11: case 18: case 25:
            msgDia = "Jueves";
            break;
        case 5: case 12: case 19: case 26:
            msgDia = "Viernes";
            break;
        case 6: case 13: case 20: case 27:
            msgDia = "Sabado";
            break;
        case 7: case 14: case 21: case 28:
            msgDia = "Domingo";
            break;
        default:
        break;
    }

    return msgDia;
}

void mostrarCalendario(int[,] matriz, string msg)
{
    int contDias = 1;
    string textCelsius = "";

    if (msg.ToLower().Equals("temperatura"))
    {
        textCelsius = "°C";
    }

    Console.WriteLine($"\t\t* * * * * {msg} del mes de mayo * * * * *\n\n");
    Console.WriteLine("LU\tMA\tMI\tJU\tVI\tSA\tDO");




    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (contDias <= 31)
            {

                Console.Write($"{matriz[i, j]}{textCelsius}\t");

            }
            contDias++;

        }
        Console.WriteLine();
    }

}


/*
 * Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera fila y la primera columna se debe guardar 
 * los números (de 0 a 9), estando el cero en la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado 
 * usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o arreglo. 
 * Al finalizar el cálculo, mostrar la matriz por pantalla
*/

void ResoluciónEjercicio7()
{
    int[,] matriz = new int[9,10];

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            matriz[i, j] = (i + 1) * (j + 1);
        }
       
    }

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        Console.WriteLine($"Tabla del {i+1}");
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.WriteLine($"{i+1} * {j+1} = {matriz[i,j]}");
        }
        Console.WriteLine();

    }


}

/*
 * Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la cantidad que el programador decida, 
 * pero no más de la mitad de los lugares disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que hay una X, 
 * ingresando la fila y la columna por separado. Informar si acertó o no por cada ingreso. Se debe pedir al usuario 
 * ingresar valores por tantas X que se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar 
 * (Ya sea porque se terminaron los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la matriz con sus 
 * correspondientes X, mostrando un * donde no haya nada.
*/

void ResoluciónEjercicio8()
{
    char[,] matriz = new char[10, 10];
    char[] arrChar = { 'X', '*'};
    int contX = 0;
    char letra;
    Random random = new Random();
    int fila, columna;

    int intentos = 3;

    for (int i = 0; i < matriz.GetLength(0); i++)
    {

        for (int j = 0; j < matriz.GetLength(1); j++)
        {

            letra = arrChar[random.Next(0, 2)];

            if (letra == 'X' && contX < 50)
            {
                matriz[i, j] = letra;
                contX++;
            } else
            {
                matriz[i, j] = '*';
            }
        }

    }


    do
    {
        Console.WriteLine("Ingrese fila y columna donde crea que este X\n");
        fila = GetIntegerDataFromUser("Ingrese la fila: ");
        columna = GetIntegerDataFromUser("Ingrese la fila: ");

        if (matriz[fila-1, columna-1] == 'X')
        {
            Console.WriteLine("Acertaste\n");
        }
        else
        {
            intentos--;
            Console.WriteLine($"No acertaste, te queda {intentos} intento/s\n");
        }
        Console.WriteLine();
        if (intentos == 0)
        {
            Console.WriteLine("Has perdidio!!!");
        }
    } while (intentos > 0);

    Console.WriteLine("\n\n\t\t* * * * * Matriz * * * * *\n\n");

    for (int i = 0; i < matriz.GetLength(0); i++)
    {

        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write($"{matriz[i,j]}  ");
        }
        Console.WriteLine();

    }


}





int GetIntegerDataFromUser(string message)
{
    string? userData;
    int data = 0;
    bool isDataValid = false;


    while (!isDataValid)
    {
        Console.Write(message);
        userData = Console.ReadLine();

        if (!Int32.TryParse(userData, out data))
        {
            Console.WriteLine("El dato que ingresaste no es valido. Vuelve a intentarlo");
        }
        else
        {
            isDataValid = true;
        }


    }

    return data;
}