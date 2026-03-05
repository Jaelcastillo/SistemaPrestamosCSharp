CREATE DATABASE SistemaPrestamosDB


USE SistemaPrestamosDB


CREATE TABLE Clientes (
    ClienteId INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto VARCHAR(100),
    Correo VARCHAR(100),
    Telefono VARCHAR(20),
    Direccion VARCHAR(200),
    Garantia VARCHAR(100),
    Sueldo DECIMAL(10,2)
);

CREATE TABLE Prestamos (
    PrestamoId INT IDENTITY(1,1) PRIMARY KEY,
    ClienteId INT,
    Monto DECIMAL(10,2),
    Meses INT,
    Interes DECIMAL(10,2),
    MontoTotal DECIMAL(10,2),
    FechaInicio DATE,

    FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId)
);

CREATE TABLE Pagos (
    PagoId INT IDENTITY(1,1) PRIMARY KEY,
    PrestamoId INT,
    MontoAnterior DECIMAL(10,2),
    InteresPagado DECIMAL(10,2),
    MontoAbonado DECIMAL(10,2),
    NuevoMonto DECIMAL(10,2),

    FOREIGN KEY (PrestamoId) REFERENCES Prestamos(PrestamoId)
);

CREATE TABLE Moras (
    MoraId INT IDENTITY(1,1) PRIMARY KEY,
    PrestamoId INT,
    MontoMora DECIMAL(10,2),
    Fecha DATE,

    FOREIGN KEY (PrestamoId) REFERENCES Prestamos(PrestamoId)
);

SELECT * 
FROM Clientes
WHERE ClienteId = @ClienteId;

SELECT *
FROM Prestamos
WHERE PrestamoId = @PrestamoId;

SELECT 
    SUM(Monto) AS TotalPrestado,
    SUM(Interes) AS TotalIntereses
FROM Prestamos;

SELECT 
    C.NombreCompleto,
    COUNT(M.MoraId) AS CantidadMoras
FROM Moras M
INNER JOIN Prestamos P ON M.PrestamoId = P.PrestamoId
INNER JOIN Clientes C ON P.ClienteId = C.ClienteId
GROUP BY C.NombreCompleto;

SELECT 
    C.NombreCompleto,
    COUNT(M.MoraId) AS TotalMoras
FROM Moras M
INNER JOIN Prestamos P ON M.PrestamoId = P.PrestamoId
INNER JOIN Clientes C ON P.ClienteId = C.ClienteId
GROUP BY C.NombreCompleto
HAVING COUNT(M.MoraId) >= 3;