
# CRUD com mongo

Este é um CRUD de filmes simples, utilizando mongoDB.

## Estrutura

### Geral
Basicamente, estou utilizando MediatR para usar padrão Request/Response, o acesso à dados é simples, utilizando apenas operações CRUD (sem UoW, RepoPatt e afins).

### Controllers
Dentro das controllers, basicamente está a operação CRUD simples, recebendo as requisições provindas do Swagger (Pode usar postman, insomnia ou thunder.. o Swagger ta ai pra facilitar só).

### Services
Dentro desta camada, estão os acessos à base de dados, sem filtro avançado, sem padrão de segurança, é algo simples, só para praticar um CRUD com mongoDB.
Não houve segregação de interface ou responsabilidade única, pois é para ser simples mesmo.

### Models
Ali está a entidade simples de filme.

### Domain
Dentro desta pasta estão os objetos de negócio, novamente, simples.

- Commands: São os comandos básicos.
- Queries: São as buscas das Queries
- Handlers: Os manipuladores, a Regra de Negócio em sí




## Documentação da API

#### Retorna todos os filmes

```http
  GET /api/movie/
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `Nenhum` | `Vazio` | Retorna todos os filmes cadastrados na base de dados (sem filtro, sem nada) |

#### Retorna um filme

```http
  GET /api/movie/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `string` | **Obrigatório**. O ID do filme em sí, ID de mongo DB contém 24 caracteres.



#### Adiciona um filme

```http
  POST /api/movie/
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `title`     | `string` | **Obrigatório**. Título do filme
| `genre`     | `string` | **Obrigatório**. Gênero do filme (Acção, aventura, e afins)
| `plot`      | `string` | **Obrigatório**. Descrição ou Plot (igual a parte de trás das fitas VHS.. sim, sou velho)
| `rating`    | `string` | **Obrigatório**. Classificação do filme, parecido com o iMDB, mas é a minha.

#### Edita um filme

```http
  PUT /api/movie/
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`        | `string` | **Obrigatório**. O ID do filme em sí, ID de mongo DB contém 24 caracteres.
| `title`     | `string` | **Obrigatório**. Título do filme
| `genre`     | `string` | **Obrigatório**. Gênero do filme (Acção, aventura, e afins)
| `plot`      | `string` | **Obrigatório**. Descrição ou Plot (igual a parte de trás das fitas VHS.. sim, sou velho)
| `rating`    | `string` | **Obrigatório**. Classificação do filme, parecido com o iMDB, mas é a minha.

#### Remove um filme pelo ID

```http
  DELETE /api/movie/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `string` | **Obrigatório**. O ID do filme em sí, ID de mongo DB contém 24 caracteres.





## Utilização

O projeto utiliza mongoDB dentro de um Docker, para facilitar, seguem os comandos

Criando um volume (para armazenar os arquivos do NoSQL)
```bash
  docker volume create VOL1
```

Criando uma rede para uso externo
```bash
  docker network create NET1
```

Subindo uma instância do banco, utilizando Volume e network.
- Não utilizo usuário e senha.
- Volume e Network são básicos, apenas para utilização.
- É simples e delicado, basicamente para demonstração.
```bash
  docker run -d --network NET1 -h mongo --name mongo -p 27017:27017 -v VOL1:/data/db mongo
```



## Sobre Readme

Este readme é gerado pelo ![Readme.So](https://readme.so)


