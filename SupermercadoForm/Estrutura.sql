CREATE TABLE categorias(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(25)
);

-- Consultar o id e nome da tabela de categorias
SELECT id, nome FROM categorias;

DELETE FROM categorias WHERE id = 5;