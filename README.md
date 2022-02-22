# desafio-toro-fullstack

# Backend

Backend desta aplicação foi construído em .Net 6.0 com a arquitetura DDD (Domain Driven Design).

Para editar ou executar, basta abrir o arquivo `Backend.sln` no Visual Studio 2022.

## Testes unitários

Os testes unitários do backend estão no projeto `UnitTests` e podem ser executados diretamente no `TestExplorer` do Visual Studio.

## Testes de API

Os testes de API estão localizados na pasta `Backend/APITests`.

Requisitos: 
 - Node (https://nodejs.org/)
 - Instalar o pacote NPX (https://www.npmjs.com/package/npx)

Por padrão, os testes de API apontam para o backend através da URL: 
```
https://localhost:44369
```


Para executar os testes de API, basta abrir o Cypress usando o comando abaixo:

```
npx cypress open
```

ou executar os testes diretamente via linha de comando:

```
npx cypress run
```



# Frontend

Frontend desta aplicação foi construído em Angular 13.

Requisitos
 - Node (https://nodejs.org/)
 - Angular CLI (https://angular.io/guide/setup-local)

Para executar, basta executar os comandos abaixo:

```
npm install
ng serve --open
```

## Testes unitários

Para executar os testes unitários de frontend, basta executar o comando abaixo:

```
ng test
```