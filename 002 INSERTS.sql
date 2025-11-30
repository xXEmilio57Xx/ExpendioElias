USE EXPENDIO;
GO

INSERT INTO EMPLEADO (EMP_NOMBRE, EMP_APELLIDO, EMP_TIPO) VALUES
('admin', 'admin', 1),
('empleado', 'empleado', 2);
GO


INSERT INTO PROVEEDOR (PRO_NOMBRE) VALUES
('TECATE'),
('DULCERIA FELIPE'),
('COCACOLA'),
('SABRITAS'),
('INDIO'),
('FOUR LOKO');
GO

INSERT INTO CATEGORIA (CAT_DESCRIPCION) VALUES
('Cerveza'),
('Alcohol en general'),
('Sabritas'),
('Dulces'),
('Refrescos'),
('Powerade'),
('Jugos Del Valle');
GO

/*
INSERT INTO PRODUCTO (PDT_ID, PDT_ID_CATEGORIA, PDT_DESCRIPCION, PDT_PRECIO, PDT_INVENTARIO) VALUES
(1, 1, 'Tecate Roja Lata 355ml', 25.00, 120),
(2, 1, 'Tecate Light Lata 355ml', 25.00, 110),
(3, 1, 'Tecate Roja Caguama 940ml', 60.00, 80),
(4, 1, 'Tecate Light Caguama 940ml', 60.00, 75),
(5, 1, 'Tecate Roja Caguama 1.2L', 70.00, 50),
(6, 1, 'Tecate Light Caguama 1.2L', 70.00, 50),
(7, 1, 'Tecate Roja Cuartito 125ml', 18.00, 60),
(8, 1, 'Tecate Light Cuartito 125ml', 18.00, 60),
(9, 1, 'Indio Lata 355ml', 27.00, 100),
(10, 1, 'Indio Caguama 940ml', 65.00, 80),
(11, 1, 'Indio Caguama 1.2L', 75.00, 50),
(12, 1, 'Indio Cuartito 125ml', 20.00, 60),
(13, 2, 'Strongbow Sidra 355ml', 45.00, 40),
(14, 2, 'Caribe Cooler 355ml', 35.00, 60),
(15, 2, 'New Mix Paloma 473ml', 40.00, 70),
(16, 2, 'Four Loko Sandía 473ml', 70.00, 30),
(17, 2, 'Four Loko Uva 473ml', 70.00, 25),
(18, 3, 'Sabritas Original 45g', 18.00, 100),
(19, 3, 'Rufles Queso 45g', 18.00, 90),
(20, 3, 'Chetos Torciditos 45g', 18.00, 80),
(21, 3, 'Tostitos Salsa Verde 65g', 25.00, 70),
(22, 3, 'Paketaxo Queso 65g', 25.00, 70),
(23, 3, 'Rancheritos 50g', 18.00, 85),
(24, 3, 'Doritos Nacho 45g', 18.00, 90),
(25, 3, 'Sabritas Adobadas 45g', 18.00, 90),
(26, 3, 'Chips Jalapeño 45g', 18.00, 90),
(27, 4, 'Mazapán 28g', 10.00, 200),
(28, 4, 'Paleta Payaso', 15.00, 120),
(29, 4, 'Chicle Motita', 2.00, 300),
(30, 4, 'Cacahuates Salados 50g', 12.00, 150),
(31, 4, 'Cacahuates Japoneses 50g', 12.00, 150),
(32, 4, 'Dulces Viejitas', 5.00, 200),
(33, 4, 'Pulparindo', 7.00, 200),
(34, 4, 'Skwinkles', 10.00, 100),
(35, 4, 'Lucas Muecas', 15.00, 100),
(36, 5, 'Coca-Cola 600ml', 20.00, 100),
(37, 5, 'Coca-Cola 2L', 38.00, 80),
(38, 5, 'Coca-Cola Lata 355ml', 18.00, 120),
(39, 5, 'Sprite 600ml', 20.00, 80),
(40, 5, 'Fanta Naranja 600ml', 20.00, 80),
(41, 5, 'Manzanita 600ml', 20.00, 60),
(42, 6, 'Powerade Azul 600ml', 25.00, 70),
(43, 6, 'Powerade Rojo 600ml', 25.00, 70),
(44, 6, 'Powerade Morado 600ml', 25.00, 70),
(45, 7, 'Jugo Del Valle Durazno 500ml', 22.00, 60),
(46, 7, 'Jugo Del Valle Mango 500ml', 22.00, 60),
(47, 7, 'Jugo Del Valle Manzana 500ml', 22.00, 60),
(75014339,3,'Catsup Del Monte 220g',20, 50)
GO
*/