-- Criação do esquema 'otomar_app_budget'
CREATE SCHEMA otomar_app_budget;

-- Criação da tabela 'bank' no esquema 'otomar_app_budget'
CREATE TABLE otomar_app_budget.bank (
    id SERIAL PRIMARY KEY,
    agency VARCHAR(20),
    name VARCHAR(255),
    current_account VARCHAR(20)
);

-- Criação da tabela 'address' no esquema 'otomar_app_budget'
CREATE TABLE otomar_app_budget.address (
    id SERIAL PRIMARY KEY,
    street VARCHAR(255) NOT NULL,
    number VARCHAR(10) NOT NULL,
    city VARCHAR(50) NOT NULL
);

-- Criação da tabela 'company' no esquema 'otomar_app_budget'
CREATE TABLE otomar_app_budget.company (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    phone VARCHAR(20) NOT NULL,
    CNPJ VARCHAR(20) NOT NULL,
    id_bank INTEGER,
    id_address INTEGER NOT NULL,
    FOREIGN KEY (id_bank) REFERENCES otomar_app_budget.bank(id),
    FOREIGN KEY (id_address) REFERENCES otomar_app_budget.address(id)
);

-- Criação da tabela 'school' no esquema 'otomar_app_budget'
CREATE TABLE otomar_app_budget.school (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    phone VARCHAR(20) NOT NULL,
    CNPJ VARCHAR(20) NOT NULL,
    id_address INTEGER NOT NULL,
    FOREIGN KEY (id_address) REFERENCES otomar_app_budget.address(id)
);

-- Criação da tabela 'note' no esquema 'otomar_app_budget'
CREATE TABLE otomar_app_budget.note (
    id SERIAL PRIMARY KEY,
    number_note VARCHAR(20) NOT NULL,
    date_budget DATE NOT NULL,
    total_products INTEGER NOT NULL,
    total DECIMAL(10, 2) NOT NULL,
    discount DECIMAL(10, 2) NOT NULL,
    PDDE VARCHAR(255) NOT NULL,
    id_school INTEGER NOT NULL,
    id_company INTEGER NOT NULL,
    FOREIGN KEY (id_company) REFERENCES otomar_app_budget.company(id),
    FOREIGN KEY (id_school) REFERENCES otomar_app_budget.school(id),
    CONSTRAINT unique_number_note UNIQUE (number_note)
);

-- Criação da tabela 'product' no esquema 'otomar_app_budget'
CREATE TABLE otomar_app_budget.product (
    id SERIAL PRIMARY KEY,
    code VARCHAR(20) NOT NULL,
    name VARCHAR(255) NOT NULL,
    quantity INTEGER NOT NULL,
    value_unit DECIMAL(10, 2) NOT NULL,
    value_total DECIMAL(10, 2) NOT NULL,
    id_note INTEGER NOT NULL,
    id_company INTEGER NOT NULL,
    id_school INTEGER NOT NULL,
    FOREIGN KEY (id_note) REFERENCES otomar_app_budget.note(id),
    FOREIGN KEY (id_company) REFERENCES otomar_app_budget.company(id),
    FOREIGN KEY (id_school) REFERENCES otomar_app_budget.school(id)
);

CREATE TABLE otomar_app_budget.budget (
    id SERIAL PRIMARY KEY,
    id_note INTEGER NOT NULL,
    id_company INTEGER NOT NULL,
    id_school INTEGER NOT NULL,
    FOREIGN KEY (id_note) REFERENCES otomar_app_budget.note(id),
    FOREIGN KEY (id_company) REFERENCES otomar_app_budget.company(id),
    FOREIGN KEY (id_school) REFERENCES otomar_app_budget.school(id)
);

