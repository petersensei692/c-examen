
USE [EXAMEN]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

PRINT '========================================';
PRINT 'Début de la migration complète...';
PRINT '========================================';
GO

-- =============================================
-- ÉTAPE 1 : SUPPRESSION DES OBJETS EXISTANTS (si nécessaire)
-- =============================================
PRINT '';
PRINT 'Étape 1 : Suppression des objets existants...';
GO

-- Suppression des vues
IF OBJECT_ID('dbo.Imprmez_Billet', 'V') IS NOT NULL DROP VIEW dbo.Imprmez_Billet;
IF OBJECT_ID('dbo.Produire_Recu', 'V') IS NOT NULL DROP VIEW dbo.Produire_Recu;
IF OBJECT_ID('dbo.Affichez_Facture', 'V') IS NOT NULL DROP VIEW dbo.Affichez_Facture;
IF OBJECT_ID('dbo.Affichez_Facture_Complete', 'V') IS NOT NULL DROP VIEW dbo.Affichez_Facture_Complete;
IF OBJECT_ID('dbo.Affichez_Agent', 'V') IS NOT NULL DROP VIEW dbo.Affichez_Agent;
IF OBJECT_ID('dbo.Affichez_Billet', 'V') IS NOT NULL DROP VIEW dbo.Affichez_Billet;
IF OBJECT_ID('dbo.Affichez_Paiement', 'V') IS NOT NULL DROP VIEW dbo.Affichez_Paiement;
IF OBJECT_ID('dbo.Affichez_Spectacle', 'V') IS NOT NULL DROP VIEW dbo.Affichez_Spectacle;
IF OBJECT_ID('dbo.Affichez_Place', 'V') IS NOT NULL DROP VIEW dbo.Affichez_Place;
GO

-- Suppression des procédures stockées
IF OBJECT_ID('dbo.sp_SaveOrUpdateClient_Flexible', 'P') IS NOT NULL DROP PROCEDURE dbo.sp_SaveOrUpdateClient_Flexible;
IF OBJECT_ID('dbo.sp_SaveOrUpdateAgent_Flexible', 'P') IS NOT NULL DROP PROCEDURE dbo.sp_SaveOrUpdateAgent_Flexible;
IF OBJECT_ID('dbo.SaveOrUpdateSalle', 'P') IS NOT NULL DROP PROCEDURE dbo.SaveOrUpdateSalle;
IF OBJECT_ID('dbo.SaveOrUpdateSpectacle', 'P') IS NOT NULL DROP PROCEDURE dbo.SaveOrUpdateSpectacle;
IF OBJECT_ID('dbo.SaveOrUpdatePlace', 'P') IS NOT NULL DROP PROCEDURE dbo.SaveOrUpdatePlace;
IF OBJECT_ID('dbo.SaveOrUpdatePaiement', 'P') IS NOT NULL DROP PROCEDURE dbo.SaveOrUpdatePaiement;
IF OBJECT_ID('dbo.SaveOrUpdateFacture', 'P') IS NOT NULL DROP PROCEDURE dbo.SaveOrUpdateFacture;
IF OBJECT_ID('dbo.SaveOrUpdateBillet', 'P') IS NOT NULL DROP PROCEDURE dbo.SaveOrUpdateBillet;
IF OBJECT_ID('dbo.Production_Facture', 'P') IS NOT NULL DROP PROCEDURE dbo.Production_Facture;
IF OBJECT_ID('dbo.CreateVenteComplete', 'P') IS NOT NULL DROP PROCEDURE dbo.CreateVenteComplete;
GO

-- Suppression des tables (dans l'ordre inverse des dépendances)
-- D'abord supprimer les tables qui ont des dépendances (tPaiement dépend de tBillets)
IF OBJECT_ID('dbo.tPaiement', 'U') IS NOT NULL DROP TABLE dbo.tPaiement;
IF OBJECT_ID('dbo.tBillets', 'U') IS NOT NULL DROP TABLE dbo.tBillets;
IF OBJECT_ID('dbo.tFacture', 'U') IS NOT NULL DROP TABLE dbo.tFacture;
IF OBJECT_ID('dbo.tPlace', 'U') IS NOT NULL DROP TABLE dbo.tPlace;
IF OBJECT_ID('dbo.tSpectacle', 'U') IS NOT NULL DROP TABLE dbo.tSpectacle;
IF OBJECT_ID('dbo.tAgents', 'U') IS NOT NULL DROP TABLE dbo.tAgents;
IF OBJECT_ID('dbo.tClients', 'U') IS NOT NULL DROP TABLE dbo.tClients;
IF OBJECT_ID('dbo.tSalle', 'U') IS NOT NULL DROP TABLE dbo.tSalle;
IF OBJECT_ID('dbo.tCategorie', 'U') IS NOT NULL DROP TABLE dbo.tCategorie;
GO

PRINT 'Étape 1 terminée.';
GO

-- =============================================
-- ÉTAPE 2 : CRÉATION DES TABLES
-- =============================================
PRINT '';
PRINT 'Étape 2 : Création des tables...';
GO

-- 1. Table tCategorie (Aucune dépendance)
CREATE TABLE dbo.tCategorie (
    id INT IDENTITY(1,1) PRIMARY KEY,
    designation NVARCHAR(100) NOT NULL
);
GO

-- 2. Table tSalle (Aucune dépendance)
CREATE TABLE dbo.tSalle (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nomSalle NVARCHAR(100) NOT NULL,
    adresse NVARCHAR(255),
    nombrePlace NVARCHAR(50) 
);
GO

-- 3. Table tClients (Aucune dépendance)
CREATE TABLE dbo.tClients (
    id INT IDENTITY(1,1) PRIMARY KEY,
    noms NVARCHAR(100) NOT NULL,
    adresse NVARCHAR(255),
    contact NVARCHAR(50),
    genre NVARCHAR(20),
    age INT
);
GO

-- 4. Table tAgents (Dépend de tSalle)
CREATE TABLE dbo.tAgents (
    id INT IDENTITY(1,1) PRIMARY KEY,
    noms NVARCHAR(100) NOT NULL,
    contact NVARCHAR(50),
    fonction NVARCHAR(50),
    role NVARCHAR(50),
    username NVARCHAR(50),
    [password] NVARCHAR(255),
    refSalle INT,
    CONSTRAINT FK_Agents_Salle FOREIGN KEY (refSalle) REFERENCES dbo.tSalle(id)
);
GO

-- 5. Table tSpectacle (Dépend de tSalle)
CREATE TABLE dbo.tSpectacle (
    id INT IDENTITY(1,1) PRIMARY KEY,
    titre NVARCHAR(200) NOT NULL,
    dateSpectacle DATETIME,
    nombreBillet INT,
    duree NVARCHAR(50),
    descSpect NVARCHAR(MAX),
    refSalle INT,
    CONSTRAINT FK_Spectacle_Salle FOREIGN KEY (refSalle) REFERENCES dbo.tSalle(id)
);
GO

-- 6. Table tPlace (Dépend de tSalle et tCategorie)
CREATE TABLE dbo.tPlace (
    id INT IDENTITY(1,1) PRIMARY KEY,
    refCategorie INT,
    numPlace NVARCHAR(50),
    refSalle INT,
    CONSTRAINT FK_Place_Categorie FOREIGN KEY (refCategorie) REFERENCES dbo.tCategorie(id),
    CONSTRAINT FK_Place_Salle FOREIGN KEY (refSalle) REFERENCES dbo.tSalle(id)
);
GO

-- 7. Table tFacture (Dépend de tClients, tAgents, tPlace)
CREATE TABLE dbo.tFacture (
    id INT IDENTITY(1,1) PRIMARY KEY,
    refClient INT,
    refAgent INT,
    refPlace INT,
    CONSTRAINT FK_Facture_Client FOREIGN KEY (refClient) REFERENCES dbo.tClients(id),
    CONSTRAINT FK_Facture_Agent FOREIGN KEY (refAgent) REFERENCES dbo.tAgents(id),
    CONSTRAINT FK_Facture_Place FOREIGN KEY (refPlace) REFERENCES dbo.tPlace(id)
);
GO

-- 8. Table tBillets (Dépend de plusieurs tables, y compris tFacture)
CREATE TABLE dbo.tBillets (
    id INT IDENTITY(1,1) PRIMARY KEY,
    dateAchat DATETIME,
    prix DECIMAL(18, 2),
    statut BIT,
    RefClient INT NULL,
    RefAgent INT NOT NULL,
    RefCat INT NULL,
    RefSpectacle INT NOT NULL,
    refFacture INT NULL,
    RefPlace INT NOT NULL,
    CONSTRAINT FK_Billets_Agent FOREIGN KEY (RefAgent) REFERENCES dbo.tAgents(id),
    CONSTRAINT FK_Billets_Spectacle FOREIGN KEY (RefSpectacle) REFERENCES dbo.tSpectacle(id),
    CONSTRAINT FK_Billets_Place FOREIGN KEY (RefPlace) REFERENCES dbo.tPlace(id),
    CONSTRAINT FK_Billets_Client FOREIGN KEY (RefClient) REFERENCES dbo.tClients(id),
    CONSTRAINT FK_Billets_Categorie FOREIGN KEY (RefCat) REFERENCES dbo.tCategorie(id),
    CONSTRAINT FK_Billets_Facture FOREIGN KEY (refFacture) REFERENCES dbo.tFacture(id)
);
GO

-- 9. Table tPaiement (Dépend de tClients, tAgents et tBillets)
CREATE TABLE dbo.tPaiement (
    id INT IDENTITY(1,1) PRIMARY KEY,
    datePaiement DATETIME,
    modePaiement NVARCHAR(50),
    montant DECIMAL(18, 2),
    refClient INT,
    refAgent INT,
    refBillet INT,
    CONSTRAINT FK_Paiement_Client FOREIGN KEY (refClient) REFERENCES dbo.tClients(id),
    CONSTRAINT FK_Paiement_Agent FOREIGN KEY (refAgent) REFERENCES dbo.tAgents(id),
    CONSTRAINT FK_Paiement_Billet FOREIGN KEY (refBillet) REFERENCES dbo.tBillets(id)
);
GO

PRINT 'Étape 2 terminée : Toutes les tables ont été créées.';
GO

-- =============================================
-- ÉTAPE 3 : INSERTION DES DONNÉES DE BASE
-- =============================================
PRINT '';
PRINT 'Étape 3 : Insertion des données de base...';
GO

-- Insertion des catégories
INSERT INTO dbo.tCategorie (designation) VALUES ('Basique'), ('VIP');
GO

-- Insertion des salles
INSERT INTO dbo.tSalle (nomSalle, adresse, nombrePlace) VALUES 
('Salle Fikin', 'Boulevard du 30 Juin, Kinshasa', '5000'),
('Grand Théâtre de Kinshasa', 'Av. de la Justice, Gombe', '1200'),
('Stade des Martyrs', 'Rue de la Victoire', '80000');
GO

-- Insertion des spectacles
INSERT INTO dbo.tSpectacle (titre, dateSpectacle, nombreBillet, duree, descSpect, refSalle) VALUES 
('Concert de Fally Ipupa', '2024-12-31 20:00:00', 4500, '03h00', 'Soirée exceptionnelle Power Nkossa', 1),
('Pièce : Les Misérables', '2024-11-15 18:30:00', 1000, '02h15', 'Classique du théâtre français', 2),
('Festival de Rumba', '2024-08-30 16:00:00', 50000, '08h00', 'Grande fête de la musique congolaise', 3);
GO

-- Insertion des clients
INSERT INTO dbo.tClients (noms, adresse, contact, genre, age) VALUES 
('Mutombo Jean-Pierre', 'Limete, Kinshasa', '+243997001122', 'M', 35),
('Mboshi Marie-Claire', 'Matete, Kinshasa', '+243998002233', 'F', 28),
('Kabongo Serge', 'Lingwala, Kinshasa', '+243995003344', 'M', 42),
('Mbuji Maya', 'Ngaliema, Kinshasa', '+243991004455', 'F', 25);
GO

-- Insertion des agents (mot de passe : 1234)
INSERT INTO dbo.tAgents (noms, contact, fonction, role, username, [password], refSalle) VALUES 
('Admin Principal', '+243810000001', 'Admin Principal', 'Gerant', 'admin', '1234', 2),
('Agent Masela', '+243810000002', 'Vendeur', 'Vendeur', 'masela', '1234', 1),
('Agent Makambo', '+243810000003', 'Comptable', 'Compable', 'makambo', '1234', 1);
GO

-- Insertion des places
INSERT INTO dbo.tPlace (numPlace, refSalle, refCategorie) VALUES 
('A-101', 1, 1), ('A-102', 1, 1), ('A-103', 1, 1),
('VIP-001', 1, 2), ('VIP-002', 1, 2),
('B-050', 2, 1), ('B-051', 2, 1);
GO

-- Insertion des factures
INSERT INTO dbo.tFacture (refClient, refAgent, refPlace) VALUES 
(1, 2, 1),
(2, 2, 4);
GO

-- Insertion des billets
INSERT INTO dbo.tBillets (prix, dateAchat, statut, RefSpectacle, RefClient, RefAgent, refFacture, RefPlace, RefCat) VALUES 
(50.00, '2024-10-01 10:00:00', 0, 1, 1, 2, 1, 1, 1),
(150.00, '2024-10-01 10:05:00', 0, 1, 2, 2, 2, 4, 2);
GO

-- Insertion des paiements
INSERT INTO dbo.tPaiement (datePaiement, modePaiement, montant, refAgent, refClient) VALUES 
('2024-10-01 10:10:00', 'Mobile Money (Airtel)', 50.00, 2, 1),
('2024-10-01 10:15:00', 'Espèces (CDF)', 150.00, 2, 2);
GO

PRINT 'Étape 3 terminée : Données de base insérées.';
GO

-- =============================================
-- ÉTAPE 4 : CRÉATION DES PROCÉDURES STOCKÉES
-- =============================================
PRINT '';
PRINT 'Étape 4 : Création des procédures stockées...';
GO

-- 1. Procédure pour Clients
CREATE PROCEDURE dbo.sp_SaveOrUpdateClient_Flexible
    @id INT,
    @noms NVARCHAR(100),
    @adresse NVARCHAR(255),
    @contact NVARCHAR(50),
    @genre NVARCHAR(20),
    @age INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.tClients WHERE id = @id AND @id > 0)
    BEGIN
        UPDATE dbo.tClients
        SET noms = @noms, adresse = @adresse, contact = @contact, genre = @genre, age = @age
        WHERE id = @id;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tClients (noms, adresse, contact, genre, age)
        VALUES (@noms, @adresse, @contact, @genre, @age);
    END
END
GO

-- 2. Procédure pour Agents
CREATE PROCEDURE dbo.sp_SaveOrUpdateAgent_Flexible
    @id INT,
    @noms NVARCHAR(100),
    @contact NVARCHAR(50),
    @fonction NVARCHAR(50),
    @role NVARCHAR(50),
    @username NVARCHAR(50),
    @pwd NVARCHAR(255),
    @refSalle INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.tAgents WHERE id = @id AND @id > 0)
    BEGIN
        UPDATE dbo.tAgents
        SET noms = @noms, contact = @contact, fonction = @fonction, role = @role, username = @username, [password] = @pwd, refSalle = @refSalle
        WHERE id = @id;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tAgents (noms, contact, fonction, role, username, [password], refSalle)
        VALUES (@noms, @contact, @fonction, @role, @username, @pwd, @refSalle);
    END
END
GO

-- 3. Procédure pour Salle
CREATE PROCEDURE dbo.SaveOrUpdateSalle
    @id INT,
    @nomSalle NVARCHAR(100),
    @adresse NVARCHAR(255),
    @nombrePlace NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.tSalle WHERE id = @id AND @id > 0)
    BEGIN
        UPDATE dbo.tSalle
        SET nomSalle = @nomSalle, adresse = @adresse, nombrePlace = @nombrePlace
        WHERE id = @id;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tSalle (nomSalle, adresse, nombrePlace)
        VALUES (@nomSalle, @adresse, @nombrePlace);
    END
END
GO

-- 4. Procédure pour Spectacle
CREATE PROCEDURE dbo.SaveOrUpdateSpectacle
    @id INT,
    @titre NVARCHAR(200),
    @dateSpectacle DATETIME,
    @nombreBillet INT,
    @duree NVARCHAR(50),
    @descriptionSpectacle NVARCHAR(MAX),
    @refSalle INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.tSpectacle WHERE id = @id AND @id > 0)
    BEGIN
        UPDATE dbo.tSpectacle
        SET titre = @titre, dateSpectacle = @dateSpectacle, nombreBillet = @nombreBillet, duree = @duree, descSpect = @descriptionSpectacle, refSalle = @refSalle
        WHERE id = @id;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tSpectacle (titre, dateSpectacle, nombreBillet, duree, descSpect, refSalle)
        VALUES (@titre, @dateSpectacle, @nombreBillet, @duree, @descriptionSpectacle, @refSalle);
    END
END
GO

-- 5. Procédure pour Place
CREATE PROCEDURE dbo.SaveOrUpdatePlace
    @id INT,
    @numero NVARCHAR(50),
    @refSalle INT,
    @refCategorie INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.tPlace WHERE id = @id AND @id > 0)
    BEGIN
        UPDATE dbo.tPlace
        SET numPlace = @numero, refSalle = @refSalle, refCategorie = @refCategorie
        WHERE id = @id;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tPlace (numPlace, refSalle, refCategorie)
        VALUES (@numero, @refSalle, @refCategorie);
    END
END
GO

-- 6. Procédure pour Paiement
CREATE PROCEDURE dbo.SaveOrUpdatePaiement
    @id INT,
    @datePaiement DATETIME,
    @modePaiement NVARCHAR(50),
    @montant DECIMAL(18, 2),
    @refAgent INT,
    @refClient INT,
    @refBillet INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.tPaiement WHERE id = @id AND @id > 0)
    BEGIN
        UPDATE dbo.tPaiement
        SET datePaiement = @datePaiement, modePaiement = @modePaiement, montant = @montant, refAgent = @refAgent, refClient = @refClient, refBillet = @refBillet
        WHERE id = @id;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tPaiement (datePaiement, modePaiement, montant, refAgent, refClient, refBillet)
        VALUES (@datePaiement, @modePaiement, @montant, @refAgent, @refClient, @refBillet);
    END
END
GO

-- 7. Procédure pour Facture
CREATE PROCEDURE dbo.SaveOrUpdateFacture
    @id INT,
    @refClient INT,
    @refAgent INT,
    @refPlace INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.tFacture WHERE id = @id AND @id > 0)
    BEGIN
        UPDATE dbo.tFacture
        SET refClient = @refClient, refAgent = @refAgent, refPlace = @refPlace
        WHERE id = @id;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tFacture (refClient, refAgent, refPlace)
        VALUES (@refClient, @refAgent, @refPlace);
    END
END
GO

-- Procédure pour créer une vente complète (Facture + Billet)
CREATE PROCEDURE dbo.CreateVenteComplete
    @prix DECIMAL(18, 2),
    @dateAchat DATETIME,
    @refSpectacle INT,
    @refClient INT,
    @refAgent INT,
    @refPlace INT,
    @refCat INT,
    @factureId INT OUTPUT,
    @billetId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Créer la facture
        INSERT INTO dbo.tFacture (refClient, refAgent, refPlace)
        VALUES (@refClient, @refAgent, @refPlace);
        
        SET @factureId = SCOPE_IDENTITY();
        
        -- Créer le billet avec référence à la facture
        INSERT INTO dbo.tBillets (prix, dateAchat, statut, RefSpectacle, RefClient, RefAgent, refFacture, RefPlace, RefCat)
        VALUES (@prix, @dateAchat, 0, @refSpectacle, @refClient, @refAgent, @factureId, @refPlace, @refCat);
        
        SET @billetId = SCOPE_IDENTITY();
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- 8. Procédure pour Billet
CREATE PROCEDURE dbo.SaveOrUpdateBillet
    @id INT,
    @prix DECIMAL(18, 2),
    @dateAchat DATETIME,
    @statut BIT,
    @refSpectacle INT,
    @refClient INT,
    @refAgent INT,
    @refFacture INT,
    @refPlace INT,
    @refCat INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.tBillets WHERE id = @id AND @id > 0)
    BEGIN
        UPDATE dbo.tBillets
        SET prix = @prix, dateAchat = @dateAchat, statut = @statut, 
            RefSpectacle = @refSpectacle, RefClient = @refClient, RefAgent = @refAgent, 
            refFacture = @refFacture, RefPlace = @refPlace, RefCat = @refCat
        WHERE id = @id;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tBillets (prix, dateAchat, statut, RefSpectacle, RefClient, RefAgent, refFacture, RefPlace, RefCat)
        VALUES (@prix, @dateAchat, @statut, @refSpectacle, @refClient, @refAgent, @refFacture, @refPlace, @refCat);
    END
END
GO

-- 9. Procédure pour Production_Facture
CREATE PROCEDURE dbo.Production_Facture
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 1; 
END
GO

PRINT 'Étape 4 terminée : Toutes les procédures stockées ont été créées.';
GO

-- =============================================
-- ÉTAPE 5 : CRÉATION DES VUES
-- =============================================
PRINT '';
PRINT 'Étape 5 : Création des vues...';
GO

-- Vue pour Affichez_Facture (avec noms au lieu d'IDs)
CREATE VIEW dbo.Affichez_Facture AS
SELECT 
    f.id,
    c.noms AS Client,
    a.noms AS Agent,
    pl.numPlace AS [Numero Place],
    sal.nomSalle AS Salle,
    cat.designation AS Categorie,
    b.id AS [Numero Billet],
    b.prix AS [Prix Billet],
    b.dateAchat AS [Date Achat],
    s.titre AS Spectacle,
    s.dateSpectacle AS [Date du Spectacle],
    paie.montant AS [Montant Paiement],
    paie.modePaiement AS [Mode de Paiement],
    paie.datePaiement AS [Date de Paiement]
FROM dbo.tFacture f
INNER JOIN dbo.tClients c ON f.refClient = c.id
INNER JOIN dbo.tAgents a ON f.refAgent = a.id
INNER JOIN dbo.tPlace pl ON f.refPlace = pl.id
INNER JOIN dbo.tSalle sal ON pl.refSalle = sal.id
INNER JOIN dbo.tCategorie cat ON pl.refCategorie = cat.id
LEFT JOIN dbo.tBillets b ON b.refFacture = f.id
LEFT JOIN dbo.tSpectacle s ON b.RefSpectacle = s.id
LEFT JOIN dbo.tPaiement paie ON paie.refBillet = b.id;
GO

-- Vue pour afficher tFacture avec noms (pour le DataGridView principal)
CREATE VIEW dbo.Affichez_Facture_Complete AS
SELECT 
    f.id,
    c.noms AS Client,
    a.noms AS Agent,
    p.numPlace AS Place,
    sal.nomSalle AS Salle,
    cat.designation AS Categorie
FROM dbo.tFacture f
INNER JOIN dbo.tClients c ON f.refClient = c.id
INNER JOIN dbo.tAgents a ON f.refAgent = a.id
INNER JOIN dbo.tPlace p ON f.refPlace = p.id
INNER JOIN dbo.tSalle sal ON p.refSalle = sal.id
INNER JOIN dbo.tCategorie cat ON p.refCategorie = cat.id;
GO

-- Vue pour Produire_Recu
CREATE VIEW dbo.Produire_Recu AS
SELECT 
    p.id,
    p.montant,
    p.datePaiement,
    p.modePaiement,
    c.noms AS Client,
    a.noms AS Agent,
    b.id AS [Numero Billet],
    b.prix AS [Prix Billet],
    s.titre AS Spectacle,
    s.dateSpectacle AS [Date du Spectacle],
    pl.numPlace AS [Numero Place],
    sal.nomSalle AS Salle
FROM dbo.tPaiement p
INNER JOIN dbo.tClients c ON p.refClient = c.id
INNER JOIN dbo.tAgents a ON p.refAgent = a.id
LEFT JOIN dbo.tBillets b ON p.refBillet = b.id
LEFT JOIN dbo.tSpectacle s ON b.RefSpectacle = s.id
LEFT JOIN dbo.tPlace pl ON b.RefPlace = pl.id
LEFT JOIN dbo.tSalle sal ON pl.refSalle = sal.id;
GO

-- Vue pour Imprmez_Billet
CREATE VIEW dbo.Imprmez_Billet AS
SELECT 
    b.id,
    b.prix,
    b.dateAchat,
    b.statut,
    s.titre AS Spectacle,
    s.dateSpectacle AS [Date du Spectacle],
    c.noms AS Client,
    a.noms AS Agent,
    p.numPlace AS [Numero Place],
    sal.nomSalle AS Salle
FROM dbo.tBillets b
INNER JOIN dbo.tSpectacle s ON b.RefSpectacle = s.id
LEFT JOIN dbo.tClients c ON b.RefClient = c.id
INNER JOIN dbo.tAgents a ON b.RefAgent = a.id
INNER JOIN dbo.tPlace p ON b.RefPlace = p.id
INNER JOIN dbo.tSalle sal ON p.refSalle = sal.id;
GO

-- Vue pour Affichez_Agent (vue manquante pour la recherche)
CREATE VIEW dbo.Affichez_Agent AS
SELECT 
    a.id AS numero,
    a.noms AS Noms,
    a.contact AS Telephone,
    a.fonction AS Fonction,
    a.role AS Role,
    a.username AS Username,
    a.[password] AS [Mot de Passe],
    s.nomSalle AS Salle
FROM dbo.tAgents a
LEFT JOIN dbo.tSalle s ON a.refSalle = s.id;
GO

-- Vue pour Affichez_Billet (vue manquante pour la recherche)
CREATE VIEW dbo.Affichez_Billet AS
SELECT 
    b.id,
    b.dateAchat,
    b.prix,
    b.statut,
    s.titre AS Spectacle,
    s.dateSpectacle AS [Date du Spectacle],
    p.numPlace AS Numero_Place,
    a.noms AS Agent,
    c.noms AS Client
FROM dbo.tBillets b
INNER JOIN dbo.tSpectacle s ON b.RefSpectacle = s.id
INNER JOIN dbo.tPlace p ON b.RefPlace = p.id
INNER JOIN dbo.tAgents a ON b.RefAgent = a.id
LEFT JOIN dbo.tClients c ON b.RefClient = c.id;
GO

-- Vue pour Affichez_Paiement (vue manquante pour la recherche)
CREATE VIEW dbo.Affichez_Paiement AS
SELECT 
    p.id AS [Numero Paiement],
    p.datePaiement AS [Date de Paiement],
    p.modePaiement AS [Mode de Paiement],
    p.montant AS [Montant a Payer],
    a.noms AS Agent,
    b.id AS [Numero Billet]
FROM dbo.tPaiement p
INNER JOIN dbo.tAgents a ON p.refAgent = a.id
LEFT JOIN dbo.tBillets b ON p.refBillet = b.id;
GO

-- Vue pour Affichez_Spectacle (vue manquante pour la recherche)
CREATE VIEW dbo.Affichez_Spectacle AS
SELECT 
    s.id,
    s.titre,
    s.dateSpectacle AS [Date du Spectacle],
    s.nombreBillet AS [Nombre Total Billet],
    s.duree AS [Duree du Spectacle en h],
    s.descSpect AS Description,
    sal.nomSalle AS Salle
FROM dbo.tSpectacle s
INNER JOIN dbo.tSalle sal ON s.refSalle = sal.id;
GO

-- Vue pour Affichez_Place (vue manquante pour la recherche)
CREATE VIEW dbo.Affichez_Place AS
SELECT 
    p.id,
    cat.designation AS Categorie,
    p.numPlace AS Numero_place,
    sal.nomSalle AS Salle
FROM dbo.tPlace p
INNER JOIN dbo.tCategorie cat ON p.refCategorie = cat.id
INNER JOIN dbo.tSalle sal ON p.refSalle = sal.id;
GO

PRINT 'Étape 5 terminée : Toutes les vues ont été créées.';
GO

-- =============================================
-- FIN DE LA MIGRATION
-- =============================================
PRINT '';
PRINT '========================================';
PRINT 'Migration terminée avec succès !';
PRINT '========================================';
PRINT '';
PRINT 'Résumé :';
PRINT '- Tables créées : 9';
PRINT '- Procédures stockées créées : 9';
PRINT '- Vues créées : 9';
PRINT '- Données de base insérées';
PRINT '';
PRINT 'La base de données EXAMEN est prête à être utilisée.';
PRINT '========================================';
GO
