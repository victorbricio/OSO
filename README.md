# OSO

OSO es un juego que consiste en lo siguiente:
  - Hay un tablero vacío en el que cada jugador (2 jugadores) pondrán letras, las letras que pueden poner serán la O y la S indistintamente.
  - Siempre que algún jugador forme la palabra OSO ganará un punto, no importa quien puso las letras anteriores, para ganar el punto hay que poner la última letra.
  - Poniendo una única letra es posible ganar más de un punto.
  - El jugador que tenga más puntos ganará la partida.
  
 En este caso, este juego fue desarrollado para la asignatura de Taller de Geometría y Tolopología. De modo que existen dos modalidades distintas que pueden resultar extrañas para aquellos que tengan pocos conocimientos en topología.
 
 Los modos son los siguientes:
  - Toro: en la modalidad de Toro el tablero que tenemos (de 5x5) tiene la estructura de un toro matemático. En topología, un toro matemático se puede representar como un cuadrado en el que los lados paralelos está identificados directamente. 
  Esto quieres decir que si tenemos una S en la casilla (0,0) y una O en la casilla (1,0), si un jugador pusiera una O en la casilla (4,0) este jugador ganaría un punto, pues ese OSO está alineado en el toro, ya que la frontera superior está identificada con la frontera inferior. Lo mismo pasará con la frontera de la derecha y de la izquierda.
  Topotlogicamente hablando esta es la representación plana de un toro.
  - 2-Toro: Esta modalidad es esencialmente igual que la anterior, pero en este caso, además de estar identificadas las fronteras superior e inferior, y las fronteras derecha e izquierda, también están identificadas las fronteras con colores iguales. 
  Topotlogicamente hablando esta es la representación plana de un 2-toro.
  
  He subido también un zip en el que está el ejecutable para Windows del juego. Si se quiere probar no eliminar los archivos que hay junto al ejecutable. El ejecutable es Oso.exe.
  Una vez iniciado el juego, y que se ha elegido una modalidad veremos lo siguiente:
    - En la parte de la derecha, desde arriba hasta abajo, se ve lo siguiente:
      - Si es el turno del jugador 1 se verá una etiqueta con el número 1 (que simboliza que es el turno del jugador 1), si no es su turno no se verá la etiqueta.
      - Se ve una etiqueta que indica los puntos del jugador 1.
      - Se ve una etiqueta que indica los puntos del jugador 2.
      - Si es el turno del jugador 2 se verá una etiqueta con el número 2 (que simboliza que es el turno del jugador 2), si no es su turno no se verá la etiqueta.
  - En la parte de la izquierda, desde arriba hasta abajo, se ve lo siguiente:
    - Un botón con la letra O, si uno de los jugadores quiere utlizar la letra O deberá pulsar este botón.
    - Un botón que finaliza la partida y nos lleva de vuelta a la elección de modalidad.
    - Un botón con la letra S, si uno de los jugadores quiere utlizar la letra S deberá pulsar este botón.
    (Por defecto, al principio, si no se pulsa ni el botón O ni el botón S se escribirá una O).
  
  Si alguien quiere ver el código o quiere modificarlo deberá entrar en la carpeta Assets, aquí vemos la carpeta _Scenes_ en la que están las tres escenas que he usado en Unity para hacer la aplicación, y la carpeta Scripts en la que están los archivos de código en C# para que funcione la aplicación.
  
Si se quisiera modificar el código bastaría con crear un proyecto de Unity y cambiar la carpeta Assets que nos da el nuevo proyecto por defecto por esta carpeta de Assets. A partir de ahí, ya se puede ejecutar y hacer cambios en el código o en las escenas, o añadir más código o escenas. No he podido subir todo el proyecto, pues es muy pesado.
  
  
  Este código es libre para quien quiera utilizarlo, pero si se quiere utilizar es de agradecer que se mencione este repositorio.
