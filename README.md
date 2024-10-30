# Juegos2D Camara
 
## 1. Instalar el paquete CineMachine y configurar 2 cámaras virtuales con diferentes zonas de seguimiento al jugador. Mostar el efecto mediante un gif animado.

Creamos un proyecto en 2D el instalamos el paquete **Cinemachine** desde el Package Manager

![cinemachine](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/1.%20cinemachine.PNG)

Una vez hecho esto, pulsamos click derecho sobre la ventana de *Hierarchy* y creamos una camara virual de cinemachine (*Cinemachine -> 2D camera*). Esto hará que se añada de forma automática el componente CinemachineBrain a la camara principal.

Tras crear las dos cámaras, asignamos el objetivo a seguir de las camaras virtuales (en este caso el player) y asignamos la propiedad de **Lens Ortho Size** de ambas para cambiar el tamaño de la lente en diferentes tamaños. En una cámara virtual cambiaremos la propiedad de **LookAheadTime** y **LookAheadSmoothing** para que la cámara se adelante al movimiento del personaje mientras que en la otra modificamos la propiedad de **Tracked Object Offset** para seguir al objeto en el cuadrante inferior izquierdo.

![camara virtual](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/2.%20Camaras%20virtuales.PNG)

### Cámara virtual 1 y 2

![diferencia](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/3.%20Ejecucion%20camaras%20virtuales.gif)

## 2. Define un área de confinamiento diferente para cada una de las dos cámaras de la tarea anterior. Realiza una prueba de ejecución con el correspondiente gif animado que permita ver las diferencias.

Para hacer esto debemos añadir el componente de **CinemachineConfiner2D** a ambas cámaras virtuales.

![confiner](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/4.%20Cofiner.png)

Tras esto creaamos dos objetos vacios y le añadimos el componente **PollygonCollder2D** y lo editamos para darle la forma que queremos, esto hará que el área seleccionada actue como confinamiento.
Luego, asignamos el objeto creado anteriormente al valor **CinemachineConfiner2D.BoundingShape2D** en nuestras cámaras virtuales.

### Cámara virtual 1 

![con1](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/5.%20Ejecucion%20cofiner1.gif)

### Cámara virtual 2

![con2](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/6.%20Ejecucion%20cofiner2.gif)

## 3. Seguimiento a un grupo de objetivos.
### a. Agrega varios sprites en la escena que estén realizando un movimiento (mínimo 3). Genera una cámara adicional que le haga el seguimiento a dichos objetos.

Añadimos dos objetos más al que teníamos y le asignaremos un movimiento mediante un [script](https://github.com/Alu0101030562/Juegos2D-Camara/blob/main/Assets/Scripts/EnemyMovement.cs)

Con los tres objetos en la escena, crearemos un objeto Cinemachine llamado **Target Group Camera**. lo que esto hará será crear un camara virtual a la que poder asignar distintos objetos. Seleccionamos los tres objetos y lo ejecutamos.

![target](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/7.%20Target%20Group%20camera.PNG)

![Animacion target](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/8.%20Ejecuci%C3%B3n%20group%20target.gif)

### b. Agrega 2 sprites adicionales en la escena que estén realizando un movimiento Genera una cámara adicional que le haga el seguimiento a dichos objetos, cada uno con un peso en la importancia del seguimiento diferente.

Agregamos 2 sprites adicionales y le damos diferentes pesos en el objeto **Target Group Camera**.

![peso](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/9.%20Peso%20objetos.PNG)

![animacion peso](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/10.%20Ejecuci%C3%B3n%20group%20target%20con%20pesos.gif)

## 4. Impulso.
### a. Cinemachine Impulse Source: el impulso se genera en respuesta a un evento
Añadimos el componente **CinemachineImpulseListener** en la cámara virtual y luego **CinemachineImpulseSource** en cualquier otro GameObject. El primer componente estará a la escucha de que se dispare un impulso desde CinemachineImpulseSource. Después crearemos el [script](https://github.com/Alu0101030562/Juegos2D-Camara/blob/main/Assets/Scripts/CameraShake.cs) encargado de hacer el impulso.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/11.%20Cinemachine%20impulse.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/12.%20Ejecuci%C3%B3n%20cinemachine%20impulse.gif)

### b. Cinemachine Collisión Impulse Source: el impulso se genera por una colisión

Para esto debemos añadir el componente **CinematicCollisionImpulseSource** al objeto con el queremos interactuar. Este obbjeto debe tener un componente **Collider2D**

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/13.%20Cinemachine%20impulse%20collider.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/14.%20Ejecuci%C3%B3n%20cinemachine%20impulse%20collider.gif)

## 5. Implementar un zoom a la cámara del jugador que se controle con las teclas w-s

Hacer el [script](https://github.com/Alu0101030562/Juegos2D-Camara/blob/main/Assets/Scripts/CameraZoom.cs) encargado de implementar el zoom

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/15.%20zoom%20camara.gif)

## 6. Seleccionar un conjunto de teclas que permitan hacer el cambio entre dos cámaras . (Habilitar/Deshabilitar el gameobject de la cámara virtual)

Hacemos el [script](https://github.com/Alu0101030562/Juegos2D-Camara/blob/main/Assets/Scripts/CameraSwitcher.cs) encargado de permitir el cambio de camaras (1 en el caso de la primera cámara virtual y 2 para la segunda)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/16.%20cambio%20de%20camara.gif)

## 7. Cámara rápida.
### a. Crear un script para activar la cámara lenta cuando el personaje entre en colisión con un elemento de la escena que elijas para activar esta propiedad.
### b. Crear un script para activar la cámara rápida cuando el personaje entre en colisión con un elemento de la escena que elijas para activar esta propiedad.

hacemos que el mismo [script](https://github.com/Alu0101030562/Juegos2D-Camara/blob/main/Assets/Scripts/TimeEffectTrigger.cs) sirva tanto para el primer apartado como para el segundo.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/17.%20camara%20rapida%20y%20lenta.gif)

## 8. Crear un script para intercambiar la cámara activa, una estará confinada y la otra no cuando el personaje entre en colisión con un elemento de la escena que elijas para realizar el intercambio.

Este [script](https://github.com/Alu0101030562/Juegos2D-Camara/blob/main/Assets/Scripts/CameraTransition.cs) se encargará de seleccionar la cámara virtual que tengamos asignado al objeto.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Cinemachine2D/18.%20Intercambio%20de%20c%C3%A1maras.gif)
