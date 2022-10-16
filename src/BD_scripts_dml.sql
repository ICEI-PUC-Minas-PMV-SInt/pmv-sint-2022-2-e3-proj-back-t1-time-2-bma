
INSERT INTO public.unidade_organizacional
(id_unidade_organizacional, nome, cnpj, telefone, horario_inicio, horario_fim, logradouro, numero, complemento, bairro, cep, cidade, uf)
VALUES(1, 'Cras Leste', '05.882.727/0001-63', '(34)3363-3568', '08:00', '18:00', 'Maria Madalena', '125', 'Loja 01', 'Industrial', '32225-180', 'Poços de Caldas', 'MG');

INSERT INTO public.unidade_organizacional
(id_unidade_organizacional, nome, cnpj, telefone, horario_inicio, horario_fim, logradouro, numero, complemento, bairro, cep, cidade, uf)
VALUES(2, 'Cras Centro', '80.882.727/0001-63', '(34)3263-3518', '08:00', '18:00', 'Magnum', '17', 'Loja 01', 'Centro', '33275-190', 'Poços de Caldas', 'MG');

INSERT INTO public.unidade_organizacional
(id_unidade_organizacional, nome, cnpj, telefone, horario_inicio, horario_fim, logradouro, numero, complemento, bairro, cep, cidade, uf)
VALUES(3, 'Cras Oeste', '71.882.727/0001-63', '(34)3563-3538', '08:00', '18:00', 'Algarve', '340', 'Loja 01', 'Magnólia', '35725-280', 'Poços de Caldas', 'MG');

INSERT INTO public.funcionario
(id_funcionario, nome, cpf, data_nascimento, senha, situacao, perfil_acesso, telefone, email, id_unidade_organizacional, logradouro, numero, complemento, bairro, cep, cidade, uf)
VALUES(1, 'José de Almeida Silva', '129.454.362-10','1980-12-18', '1234', 'Ativo', 'Administrador', '(31) 9528-3961', 'josealmeida@gmail.com', '2', 'Campos Rodrigues', '51', 'casa', 'serra verde', '33528-196', 'Poços de caldas', 'MG');

INSERT INTO public.beneficiario
(id_beneficiario, id_funcionario, nome, cpf, data_nascimento, situacao, beneficio_cesta_basica, beneficio_cesta_verde, id_unidade_organizacional, telefone, logradouro, numero, complemento, bairro, cep, cidade, uf)
VALUES(1, 1, 'Maria Aparecida Aguiar', '754.766.929-15', '1969-08-25', 'Ativo', 'sim','sim', 2, '(34) 9529-8739', 'Londres', '596', ' Apto 501', 'Centro', '33275-906', 'Poços de Caldas', 'MG');

INSERT INTO public.beneficiario
(id_beneficiario, id_funcionario, nome, cpf, data_nascimento, situacao, beneficio_cesta_basica, beneficio_cesta_verde, id_unidade_organizacional, telefone, logradouro, numero, complemento, bairro, cep, cidade, uf)
VALUES(2, 1, 'Ana Maria da Consolação', '154.266.329-05', '1979-07-15', 'Ativo', 'sim', 'sim', 1, '(34) 9229-7739', 'Alfa', '1596', ' Apto 301', 'Fonte Grande', '33575-103', 'Poços de Caldas', 'MG');

INSERT INTO public.cesta_doada
(id_cesta_doada, id_beneficiario, id_funcionario, id_unidade_organizacional, data_retirada_cesta_basica, data_retirada_cesta_verde, hora_retira, proxima_retirada_cesta_basica, proxima_retirada_cesta_verde, beneficio_concedido, local_retirada)
VALUES(1, 1, 1, 2, '2022-10-15', '2022-10-15', '17:30', '2022-11-15', '2022-10-30', ' Cesta Basica/verde', 'Cras Centro');


UPDATE public.unidade_organizacional
SET  horario_inicio='08:30'
WHERE id_unidade_organizacional=2;

DELETE FROM public.beneficiario
WHERE id_beneficiario=2;

select * from unidade_organizacional;
select * from funcionario;
select * from beneficiario;
select * from cesta_doada;