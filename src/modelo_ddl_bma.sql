-- DROP SCHEMA public;

CREATE SCHEMA public AUTHORIZATION postgres;

COMMENT ON SCHEMA public IS 'standard public schema';
-- public.unidade_organizacional definition

-- Drop table

-- DROP TABLE public.unidade_organizacional;

CREATE TABLE public.unidade_organizacional (
	id_unidade_organizacional int4 NOT NULL,
	nome varchar(30) NOT NULL,
	cnpj varchar(18) NOT NULL,
	telefone varchar(14) NOT NULL,
	horario_inicio varchar(5) NOT NULL,
	horario_fim varchar(5) NOT NULL,
	logradouro varchar(100) NOT NULL,
	numero varchar(15) NULL,
	complemento varchar(20) NULL,
	bairro varchar(50) NOT NULL,
	cep varchar(9) NOT NULL,
	cidade varchar(50) NOT NULL,
	uf varchar(2) NOT NULL,
	CONSTRAINT unidade_organizacional_pkey PRIMARY KEY (id_unidade_organizacional)
);

-- Permissions

ALTER TABLE public.unidade_organizacional OWNER TO postgres;
GRANT ALL ON TABLE public.unidade_organizacional TO postgres;


-- public.funcionario definition

-- Drop table

-- DROP TABLE public.funcionario;

CREATE TABLE public.funcionario (
	id_funcionario int4 NOT NULL,
	nome varchar(50) NOT NULL,
	cpf varchar(14) NOT NULL,
	data_nascimento date NOT NULL,
	senha varchar(8) NOT NULL,
	situacao varchar(15) NOT NULL,
	perfil_acesso varchar(30) NOT NULL,
	telefone varchar(14) NOT NULL,
	email varchar(50) NOT NULL,
	id_unidade_organizacional int4 NOT NULL,
	logradouro varchar(100) NOT NULL,
	numero varchar(15) NULL,
	complemento varchar(20) NULL,
	bairro varchar(50) NOT NULL,
	cep varchar(9) NOT NULL,
	cidade varchar(50) NOT NULL,
	uf varchar(2) NOT NULL,
	CONSTRAINT funcionario_pkey PRIMARY KEY (id_funcionario),
	CONSTRAINT fk_funcionario_unidade_organizacional FOREIGN KEY (id_unidade_organizacional) REFERENCES public.unidade_organizacional(id_unidade_organizacional)
);

-- Permissions

ALTER TABLE public.funcionario OWNER TO postgres;
GRANT ALL ON TABLE public.funcionario TO postgres;


-- public.beneficiario definition

-- Drop table

-- DROP TABLE public.beneficiario;

CREATE TABLE public.beneficiario (
	id_beneficiario int4 NOT NULL,
	id_funcionario int4 NOT NULL,
	nome varchar(50) NOT NULL,
	cpf varchar(14) NOT NULL,
	data_nascimento date NOT NULL,
	situacao varchar(15) NOT NULL,
	beneficio_cesta_basica varchar(10) NOT NULL,
	beneficio_cesta_verde varchar(10) NOT NULL,
	id_unidade_organizacional int4 NOT NULL,
	telefone varchar(14) NOT NULL,
	logradouro varchar(100) NOT NULL,
	numero varchar(15) NULL,
	complemento varchar(20) NULL,
	bairro varchar(50) NOT NULL,
	cep varchar(9) NOT NULL,
	cidade varchar(50) NOT NULL,
	uf varchar(2) NOT NULL,
	CONSTRAINT beneficiario_pkey PRIMARY KEY (id_beneficiario),
	CONSTRAINT fk_beneficiario_funcionario FOREIGN KEY (id_funcionario) REFERENCES public.funcionario(id_funcionario),
	CONSTRAINT fk_beneficiario_unidade_organizacional FOREIGN KEY (id_unidade_organizacional) REFERENCES public.unidade_organizacional(id_unidade_organizacional)
);

-- Permissions

ALTER TABLE public.beneficiario OWNER TO postgres;
GRANT ALL ON TABLE public.beneficiario TO postgres;


-- public.cesta_doada definition

-- Drop table

-- DROP TABLE public.cesta_doada;

CREATE TABLE public.cesta_doada (
	id_cesta_doada int4 NOT NULL,
	id_beneficiario int4 NOT NULL,
	id_funcionario int4 NOT NULL,
	id_unidade_organizacional int4 NOT NULL,
	data_retirada_cesta_basica date NOT NULL,
	data_retirada_cesta_verde date NOT NULL,
	hora_retira time NOT NULL,
	proxima_retirada_cesta_basica date NOT NULL,
	proxima_retirada_cesta_verde date NOT NULL,
	beneficio_concedido varchar(30) NOT NULL,
	local_retirada varchar(20) NOT NULL,
	CONSTRAINT cesta_doada_pkey PRIMARY KEY (id_cesta_doada),
	CONSTRAINT fk_cesta_doada_beneficiario FOREIGN KEY (id_beneficiario) REFERENCES public.beneficiario(id_beneficiario),
	CONSTRAINT fk_cesta_doada_funcionario FOREIGN KEY (id_funcionario) REFERENCES public.funcionario(id_funcionario),
	CONSTRAINT fk_cesta_doada_unidade_organizacional FOREIGN KEY (id_unidade_organizacional) REFERENCES public.unidade_organizacional(id_unidade_organizacional)
);

-- Permissions

ALTER TABLE public.cesta_doada OWNER TO postgres;
GRANT ALL ON TABLE public.cesta_doada TO postgres;




-- Permissions

GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO public;
