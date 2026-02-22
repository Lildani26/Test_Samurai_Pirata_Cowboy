// See https://aka.ms/new-console-template for more information

int C_samurai, C_pirata, C_cowboy, resultado;
C_samurai = 0;
C_pirata = 0;
C_cowboy = 0;
string  a1, a2, a3, a4, a5,a6, mensaje, nombre;
resultado = 0;
mensaje = " ";

Console.WriteLine("Hola, porfavor ingrese su nombre");
nombre = Console.ReadLine();

Console.WriteLine($"Bienvenido a este test de personalidad {nombre} donde respondiendo algunas preguntas se determinara que " +
    "que tipo de arquetipo se relaciona mas a su forma de ser.\n Porfavor dijite la letra de su respuesta");

// Empezamos a hacer las preguntas al usuario y a contar sus respuestas para determinar su arquetipo, se utiliza el metodo ToLower para que no importe si el usuario escribe mayuscula o minuscula, el programa lo tomara igual.

// Pregunta 1
Console.Write(" PREGUNTA 1. \n\n En una fiesta…\n A. Me mantengo tranquilo, observo, converso con pocos pero profundamente. \n " +
    "B.  Busco la música, bailo, hago bromas y armo caos divertido.\n " +
    "C. Me siento cómodo en un rincón, disfruto sin llamar la atención, pero si alguien me habla, soy directo y relajado.\n\n");

a1 = Console.ReadLine();
a1 = a1.ToLower();
    if (a1 == "a")
        {
            C_samurai++;
        }
    else if (a1 == "b")
        {
            C_pirata++;
        }
    else if (a1 == "c")
        {
            C_cowboy++;
        }

// Pregunta 2
Console.Write("PREGUNTA 2. \n" +
    "En una relación… \n  A. Soy leal, protector y busco estabilidad.\n " +
    "B. Soy apasionado, espontáneo y busco aventura constante. \n " +
    "C. Soy independiente, necesito espacio, pero soy confiable y sencillo. \n " +
    "Porfavor elija una opcion.\n\n");
a2 = Console.ReadLine();
a2 = a2.ToLower();
    if (a2 == "a")
        {
            C_samurai++;
        }
    else if (a2 == "b")
        {
            C_pirata++;
        }
    else if (a2 == "c")
        {
            C_cowboy++;
        }

// Pregunta 3
Console.Write("PREGUNTA 3. \n\n" +
    "En el trabajo o estudios… \n " +
    "A. Me guío por disciplina y reglas claras. \n " +
    "B. Me gusta improvisar, romper esquemas y encontrar soluciones creativas. \n " +
    "C. Prefiero lo práctico, lo directo y lo que funciona en la vida real.\n " +
    "Porfavor elegi una opcion: \n\n");
a3 = Console.ReadLine();
a3 = a3.ToLower();
    if (a3 == "a")
        {
            C_samurai++;
        }
    else if (a3 == "b")
        {
            C_pirata++;
        }
    else if (a3 == "c")
        {
            C_cowboy++;
        }

// Pregunta 4
Console.Write("PREGUNTA 4. \n\n" 
    + "Si alguien me falta al respeto…\n " +
    "A. Mantengo la calma, pero defiendo mi honor con firmeza.\n " +
    "B. Respondo con humor o rebeldía, no me dejo intimidar. \n" +
    "C. No me complico, pongo límites claros y sigo adelante. \n" +
    " Porfavor elegi una opcion: \n\n. ");
a4 = Console.ReadLine();
a4 = a4.ToLower();
    if (a4 == "a")
        {
            C_samurai++;
        }
    else if (a4 == "b")
        {
            C_pirata++;
        }
    else if (a4 == "c")
        {
            C_cowboy++;
        }

//Pregunta 5
Console.Write("PREGUNTA 6. \n\n" +
    "Mi valor más importante es…\n " +
    "A.  Honor y compromiso.\n " +
    "B. Libertad y diversión.\n " +
    "C. Independencia y resiliencia.\n " +
    "Porfavor elegi una opcion: \n\n");
a5 = Console.ReadLine();
a5 = a5.ToLower();
    if (a5 == "a")
        {
            C_samurai++;
        }
    else if (a5 == "b")
        {
            C_pirata++;
        }
    else if (a5 == "c")
        {
            C_cowboy++;
        }


//Pregunta 6
Console.Write("PREGUNTA 6. \n\n" +
    "Si fuera un animal sería… \n" +
    "A. Un tigre: fuerte, disciplinado, protector.\n " +
    "B. Un mono: juguetón, curioso, irreverente.\n " +
    "C. Un caballo: libre, resistente, trabajador\n " +
    " Porfavor elige una opcion: \n\n ");
a6 = Console.ReadLine();
a6 = a6.ToLower();
    if (a6 == "a")
        {
            C_samurai++;
        }
    else if (a6 == "b")
        {
            C_pirata++;
        }
    else if (a6 == "c")
        {
            C_cowboy++;
}


// Se utiliza un condicional para determinar que tipo de arquetipo es la el usuario, el numero le dara pie a la funtion  switch para que imprima el resultado segun el tipo


if (C_samurai > C_pirata && C_samurai > C_cowboy)
{
    resultado = 1;
}
else if (C_pirata > C_samurai && C_pirata > C_cowboy)
{
    resultado = 2;
}
else if (C_cowboy > C_samurai && C_cowboy > C_pirata)
{
    resultado = 3;
}
else resultado = 4; 

    // Se plantea el switch para que imprima el mensaje final segun el resultadi optenido.

    switch (resultado)
    {
        case 1:
            mensaje = "Tu arquetipo es el Samurai.\n " +
                "Eres una persona tranquila, observadora y profunda en tus relaciones. Te guías por la disciplina y el honor, valoras la lealtad y el compromiso, " +
                "y buscas estabilidad en tu entorno. Inspiras confianza y respeto, porque siempre actúas con integridad y autocontrol.";

            break;

        case 2:
            mensaje = "Tu arquetipo es el Pirata. \n" +
                "Eres rebelde, divertido y aventurero. Te encanta la libertad, improvisar y romper esquemas.Aportas energía y humor a cualquier situación, " +
                "y tu espontaneidad hace que la gente disfrute de tu compañía.Vives la vida como una aventura constante, sin miedo a lo inesperado.";
            break;

        case 3:
            mensaje = "Tu arquetipo es el Cowboy/ vaquero.\n" +
                "Eres independiente, pragmático y sencillo. Prefieres la autonomía y la resiliencia, enfrentando la vida con calma y practicidad. " +
                 "No necesitas grandes artificios: tu fortaleza está en tu autenticidad y tu capacidad de seguir adelante sin complicaciones. " +
                 "Inspiras respeto por tu sencillez y firmeza.esenta más.";
            break;

    }
Console.WriteLine($"Felicidades {nombre} " + mensaje);

