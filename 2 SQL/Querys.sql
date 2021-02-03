--2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.

SELECT p.pessoa_id, p.pessoa_name, E.evento_name
FROM tabela_pessoa P 
INNER JOIN tabela_evento E
WHERE P.pessoa_id = E.pessoa_id
ORDER BY P.pessoa_id ASC

--2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.

SELECT *
FROM tabela_pessoa
WHERE pessoa_name LIKE '%Doe'

--2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.

INSERT INTO tabela_evento ( evento_name, pessoa_id )
SELECT "evento", pessoa_id
FROM tabela_pessoa
WHERE pessoa_name LIKE 'Lisa Romero'

--2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'

UPDATE tabela_evento E 
SET E.pessoa_id = (SELECT P.pessoa_id FROM tabela_pessoa P WHERE p.pessoa_name = 'John Doe')
WHERE E.evento_name = 'Evento D'

--2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.

DELETE FROM tabela_evento
WHERE evento_name = 'Evento B'

--2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.

DELETE FROM tabela_pessoa
WHERE pessoa_id IN (SELECT pessoa_id FROM tabela_pessoa WHERE pessoa_id NOT IN (SELECT pessoa_id FROM tabela_evento))

--2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)

ALTER TABLE tabela_pessoa ADD Idade int;

--2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:

CREATE TABLE tabela_telefone (
    id int ,
    telefone varchar(200),
    pessoa_id int,
    PRIMARY KEY (id),
    FOREIGN KEY (pessoa_id) REFERENCES tabela_pessoa(pessoa_id)
)

--2.9 Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.

ALTER TABLE tabela_telefone
ADD UNIQUE (telefone)

--2.10 Crie uma query para remover a 'tabela_telefone'.

DROP TABLE tabela_telefone
                   
