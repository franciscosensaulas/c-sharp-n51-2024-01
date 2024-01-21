CREATE TABLE categorias(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(25)
);

-- Consultar o id e nome da tabela de categorias
SELECT id, nome FROM categorias;

DELETE FROM categorias WHERE id = 5;


CREATE TABLE estantes (
	id INT PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR(50) NOT NULL,
	sigla VARCHAR(3) NOT NULL -- NOT NULL é um campo obrigatório, ou seja, no cadastro usuário terá que informar
);

INSERT INTO estantes (nome, sigla) VALUES
('Temperos', 'A01'),
('Massas', 'A02');