# 	Parroquia Core  †

![N|Solid](https://s-media-cache-ak0.pinimg.com/236x/47/f2/36/47f236eb3089c29278b7877e91afb18c.jpg)

Parroquia core es un sistema de control para la parroquia La Santa Cruz en Guadalajara,Jalisco  . 

Usamos un numero de proyectos de open source :
* [AngularJS] 
* [Angular Material]
* [sass]
* [node.js] 
* [Gulp]
* [Webpack]

And of course Dillinger itself is open source with a [public repository][dill]
 on GitHub.

### Installacion 
Para que el proyecto funcione correctamente es necesario instalar todos los paquetes de node (estos ya estan en package.json)

```sh
$ npm install 
```

Seguido tenemos que hacer el link de npm global para poder usarlo en el archivo de gulp 

```sh
$ npm ln global-npm
```

>Es recomendable que para desarrollo se tenga la task de watch corriendo para que se recompilen los archivos .ts y .scss o .sass

```sh
$ gulp watch
```

##### Made with love :beer:



   [node.js]: <http://nodejs.org>
   [AngularJS]: <http://angularjs.org>
   [Gulp]: <http://gulpjs.com>
   [Angular Material]:<https://material.angularjs.org/latest/>
   [sass]:<http://sass-lang.com/>
   [Webpack]:<https://webpack.github.io/>
