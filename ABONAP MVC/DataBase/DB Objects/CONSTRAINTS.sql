-- ************************* NOT NULL CONSTRAINTS *****************************************

ALTER TABLE DEPARTAMENTO ALTER COLUMN ID_DEPARTAMENTO INT NOT NULL;

ALTER TABLE EMPRESA ALTER COLUMN ID_EMPRESA INT NOT NULL;

ALTER TABLE PERSONA ALTER COLUMN ID_PERSONA INT NOT NULL;

ALTER TABLE DOCUMENTO ALTER COLUMN ID_DOCUMENTO INT NOT NULL;

ALTER TABLE TIPO_DOCUMENTO ALTER COLUMN ID_TIPO_DOCUMENTO INT NOT NULL;

ALTER TABLE SUCURSAL ALTER COLUMN ID_SUCURSAL INT NOT NULL;

ALTER TABLE EMPLEADO ALTER COLUMN ID_EMPLEADO INT NOT NULL;

ALTER TABLE CLIENTE ALTER COLUMN ID_CLIENTE INT NOT NULL;

ALTER TABLE PRESTAMO ALTER COLUMN ID_PRESTAMO INT NOT NULL;

--************************** PRIMARY KEYS (LLAVES PRIMARIAS) **********************************

ALTER TABLE DEPARTAMENTO ADD CONSTRAINT PK_DEPARTAMENTO PRIMARY KEY (ID_DEPARTAMENTO);

ALTER TABLE EMPRESA ADD CONSTRAINT PK_EMPRESA PRIMARY KEY (ID_EMPRESA);

ALTER TABLE PERSONA ADD CONSTRAINT PK_PERSONA PRIMARY KEY (ID_PERSONA);

ALTER TABLE DOCUMENTO ADD CONSTRAINT PK_DOCUMENTO PRIMARY KEY (ID_DOCUMENTO);

ALTER TABLE TIPO_DOCUMENTO ADD CONSTRAINT PK_TIPO_DOCUMENTO PRIMARY KEY (ID_TIPO_DOCUMENTO);

ALTER TABLE SUCURSAL ADD CONSTRAINT PK_SUCURSAL PRIMARY KEY (ID_SUCURSAL);

ALTER TABLE EMPLEADO ADD CONSTRAINT PK_EMPLEADO PRIMARY KEY (ID_EMPLEADO);

ALTER TABLE CLIENTE ADD CONSTRAINT PK_CLIENTE PRIMARY KEY (ID_CLIENTE);

ALTER TABLE PRESTAMO ADD CONSTRAINT PK_PRESTAMO PRIMARY KEY (ID_PRESTAMO);


--************************* FOREIGN KEYS (LLAVES FORANEAS) ************************************

ALTER TABLE DEPARTAMENTO ADD CONSTRAINT FK_DEPTO_SUCURSAL 
FOREIGN KEY (ID_SUCURSAL) REFERENCES SUCURSAL (ID_SUCURSAL) ON DELETE CASCADE;

ALTER TABLE DOCUMENTO ADD CONSTRAINT FK_DOCUMENTO_TIPO_DOCUMENTO
FOREIGN KEY(ID_TIPO_DOCUMENTO) REFERENCES TIPO_DOCUMENTO (ID_TIPO_DOCUMENTO) ON DELETE CASCADE;

ALTER TABLE SUCURSAL ADD CONSTRAINT FK_SUCURSAL_EMPRESA
FOREIGN KEY (ID_EMPRESA) REFERENCES EMPRESA (ID_EMPRESA) ON DELETE CASCADE;

ALTER TABLE EMPLEADO ADD CONSTRAINT FK_EMPLEADO_PERSONA
FOREIGN KEY (ID_PERSONA) REFERENCES PERSONA (ID_PERSONA) ON DELETE CASCADE;

ALTER TABLE EMPLEADO ADD CONSTRAINT FK_EMPLEADO_SUCURSAL
FOREIGN KEY (ID_SUCURSAL) REFERENCES SUCURSAL (ID_SUCURSAL) ON DELETE CASCADE;

ALTER TABLE CLIENTE ADD CONSTRAINT FK_CLIENTE_PERSONA
FOREIGN KEY (ID_PERSONA) REFERENCES PERSONA (ID_PERSONA) ON DELETE CASCADE;

ALTER TABLE CLIENTE ADD CONSTRAINT FK_CLIENTE_SUCURSAL
FOREIGN KEY (ID_SUCURSAL) REFERENCES SUCURSAL (ID_SUCURSAL) ON DELETE CASCADE;

ALTER TABLE PRESTAMO ADD CONSTRAINT FK_PRESTAMO_CLIENTE
FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE (ID_CLIENTE) ON DELETE CASCADE;

ALTER TABLE PRESTAMO ADD CONSTRAINT FK_PRESTAMO_SUCURSAL
FOREIGN KEY (ID_SUCURSAL) REFERENCES SUCURSAL (ID_SUCURSAL);


--****************************** DEFAULT VALUES (VALORES POR DEFECTO) ************************************
ALTER TABLE DEPARTAMENTO ADD CONSTRAINT DF_FECHA_CREACION_DEPARTAMENTO 
DEFAULT (GETDATE()) FOR FECHA_CREACION;

ALTER TABLE DEPARTAMENTO ADD CONSTRAINT DF_FECHA_ACTUALIZACION_DEPARTAMENTO 
DEFAULT (GETDATE()) FOR FECHA_ACTUALIZACION;

ALTER TABLE EMPRESA ADD CONSTRAINT DF_FECHA_CREACION_EMPRESA 
DEFAULT (GETDATE()) FOR FECHA_CREACION;

ALTER TABLE EMPRESA ADD CONSTRAINT DF_FECHA_ACTUALIZACION_EMPRESA
DEFAULT (GETDATE()) FOR FECHA_ACTUALIZACION;

ALTER TABLE PERSONA ADD CONSTRAINT DF_FECHA_CREACION_PERSONA
DEFAULT (GETDATE()) FOR FECHA_CREACION;

ALTER TABLE PERSONA ADD CONSTRAINT DF_FECHA_PERSONA
DEFAULT (GETDATE()) FOR FECHA_ACTUALIZACION;

ALTER TABLE DOCUMENTO ADD CONSTRAINT DF_FECHA_CREACION_DOCUMENTO
DEFAULT (GETDATE()) FOR FECHA_CREACION;

ALTER TABLE DOCUMENTO ADD CONSTRAINT DF_FECHA_ACTUALIZACION_DOCUMENTO
DEFAULT (GETDATE()) FOR FECHA_ACTUALIZACION;

ALTER TABLE SUCURSAL ADD CONSTRAINT DF_FECHA_CREACION_SUCURSAL
DEFAULT (GETDATE()) FOR FECHA_CREACION;

ALTER TABLE SUCURSAL ADD CONSTRAINT DF_FECHA_ACTUALIZACION_SUCURSAL
DEFAULT (GETDATE()) FOR FECHA_ACTUALIZACION;

ALTER TABLE EMPLEADO ADD CONSTRAINT DF_FECHA_CREACION_EMPLEADO
DEFAULT (GETDATE()) FOR FECHA_CREACION;

ALTER TABLE EMPLEADO ADD CONSTRAINT DF_FECHA_ACTUALIZACION_EMPLEADO
DEFAULT (GETDATE()) FOR FECHA_ACTUALIZACION;

ALTER TABLE CLIENTE ADD CONSTRAINT DF_FECHA_CREACION_CLIENTE
DEFAULT (GETDATE()) FOR FECHA_CREACION;

ALTER TABLE CLIENTE ADD CONSTRAINT DF_FECHA_ACTUALIZACION_CLIENTE
DEFAULT (GETDATE()) FOR FECHA_ACTUALIZACION;

ALTER TABLE PRESTAMO ADD CONSTRAINT DF_FECHA_CREACION_PRESTAMO
DEFAULT (GETDATE()) FOR FECHA_CREACION;

ALTER TABLE PRESTAMO ADD CONSTRAINT DF_FECHA_ACTUALIZACION_PRESTAMO
DEFAULT (GETDATE()) FOR FECHA_ACTUALIZACION;


