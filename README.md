# Proyecto C# 2 - Gestor de Tareas
Proyecto 2 Tema 3

Este proyecto es una aplicación de gestión de tareas desarrollada en C# utilizando Windows Forms. 

## Resumen

La aplicación permite a los usuarios crear, editar y eliminar tareas. La lógica de la aplicación se basa en la interacción entre los formularios (interfaz gráfica de usuario) y las clases (lógica de la aplicación).

Para una explicación más detallada de la lógica de la aplicación, las decisiones de diseño tomadas, y cómo interactúa el código con la interfaz gráfica de usuario, continúe leyendo este archivo README.

# Proyecto FERNANDES_ROCCIA_TAPIA

Este proyecto es una aplicación de Windows Forms desarrollada en C#. Se trata de una aplicación de gestión de vehiculos que permite a los usuarios crear, editar y eliminar vehiculos.

## Funcionamiento del Program.cs

El archivo `Program.cs` es el punto de entrada principal de la aplicación. Aquí es donde comienza y termina la ejecución del programa.

El método `Main()` es el primer método que se ejecuta cuando se inicia la aplicación. Dentro de este método, se realizan tres operaciones principales:

1. `Application.EnableVisualStyles()`: Este método habilita los estilos visuales para la aplicación. Los estilos visuales son las características de diseño que definen la apariencia y la sensación de los controles y elementos de la interfaz de usuario.

2. `Application.SetCompatibleTextRenderingDefault(false)`: Este método se utiliza para controlar cómo se renderiza el texto en los controles y garantizar la compatibilidad con versiones anteriores de .NET.

3. `Application.Run(new Form1())`: Este método inicia un bucle de mensajes estándar de la aplicación en el hilo actual y muestra el formulario especificado. En este caso, se muestra `Form1`, que es el formulario principal de la aplicación.

Por lo tanto, `Program.cs` es responsable de iniciar la aplicación, configurar los estilos visuales y el renderizado de texto, y mostrar el formulario principal.

## Estructura General del Proyecto

El proyecto está organizado en varias carpetas para mantener el código y los recursos bien estructurados y fácilmente accesibles. Aquí está una descripción general de la estructura del proyecto:

1. **Entidades**: Esta carpeta contiene todas las clases que definen los objetos que se utilizan en la aplicación. Estas clases representan las "entidades" en la lógica de la aplicación y definen sus propiedades y comportamientos.

2. **Forms**: Esta carpeta contiene todos los formularios de la aplicación. Cada formulario consta de dos partes principales:

    - **Diseño gráfico**: Esta es la interfaz de usuario que ven los usuarios. Define la apariencia de la aplicación, incluyendo la disposición de los controles, los colores, las fuentes, etc.

    - **Código**: Este es el código que controla el comportamiento de la aplicación. Incluye el código para interactuar con el resto del programa (como las clases en la carpeta Entidades) y el código que controla el diseño gráfico.

3. **Recursos**: Esta carpeta contiene todos los recursos gráficos que se utilizan en la aplicación, como iconos e imágenes. Estos recursos se utilizan para mejorar la apariencia de la aplicación y hacerla más intuitiva para los usuarios.

La estructura del proyecto está diseñada para separar claramente la lógica de la aplicación (en la carpeta Entidades), la interfaz de usuario (en la carpeta Forms) y los recursos gráficos (en la carpeta Recursos). Esta organización facilita la navegación por el código y la modificación de diferentes partes de la aplicación.




## Lógica de la aplicación

La lógica de la aplicación se basa en la interacción entre los formularios y las clases. Cuando un usuario interactúa con un formulario (por ejemplo, al crear una tarea), el formulario llama a los métodos correspondientes en las clases para realizar la operación requerida.

Las decisiones tomadas en la lógica de la aplicación se basan en la necesidad de mantener una separación clara entre la interfaz gráfica de usuario y la lógica de la aplicación. Esto facilita el mantenimiento y la expansión de la aplicación en el futuro.

## Clases y métodos

Las clases y métodos en la aplicación son los siguientes:

- `Task`: Esta clase representa una tarea. Contiene métodos para crear, editar y eliminar tareas.
- `TaskList`: Esta clase representa una lista de tareas. Contiene métodos para agregar y eliminar tareas de la lista.
- `Form1`: Este es el formulario principal de la aplicación. Contiene métodos para interactuar con las clases `Task` y `TaskList`.

Para obtener más detalles sobre las clases y métodos, consulte el código fuente.

## Interacción entre el código y la interfaz gráfica de usuario

La interacción entre el código y la interfaz gráfica de usuario se realiza a través de los formularios. Cuando un usuario interactúa con un formulario, el formulario llama a los métodos en las clases para realizar las operaciones requeridas. Los resultados de estas operaciones se muestran luego en la interfaz gráfica de usuario.

Por ejemplo, cuando un usuario crea una tarea, el formulario llama al método `Create` en la clase `Task`. Una vez que la tarea se ha creado, se muestra en la interfaz gráfica de usuario.

## Conclusión

Este proyecto es una aplicación de gestión de tareas completa y funcional. Aunque la lógica de la aplicación puede parecer compleja al principio, se basa en principios de programación sólidos y está diseñada para ser fácil de entender y mantener. Para obtener más detalles sobre la lógica de la aplicación y las decisiones de diseño tomadas, consulte el código fuente.
