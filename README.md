# OSO

OSO es un juego que consiste en lo siguiente:
  - Hay un tablero vacío en el que cada jugador (2 jugadores) pondrán letras, las letras que pueden poner serán la O y la S.
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
  
  Si alguien quiere ver el código o quiere modificarlo deberá entrar en la carpeta Assets, aquí están la carpeta __Scenes_ en la que están las tres escenas que he usado en Unity para hacer la aplicación. Además, en la carpeta Scripts están los archivos de código en C# para que funcione la aplicación.
  
  Esto tal cual no va a funcionar, no he podido subir todo el proyecto entero pues es muy grande. Para que funcione bastaría crear un proyecto de Unity y cambiar la carpeta Assets que nos da el nuevo proyecto por defecto por esta carpeta de Assets.
  
  Este código es libre para quien quiera utilizarlo, pero si se quiere utilizar es de agradecer que se mencione este repositorio.
