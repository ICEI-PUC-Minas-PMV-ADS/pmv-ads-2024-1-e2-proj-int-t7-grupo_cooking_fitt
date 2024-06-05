IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240512141413_m01-AddIngredienteeCardapio')
BEGIN
    CREATE TABLE [Ingrediente] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        [Calorias] int NOT NULL,
        [Unidade] nvarchar(max) NOT NULL,
        [Peso] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Ingrediente] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240512141413_m01-AddIngredienteeCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240512141413_m01-AddIngredienteeCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240517124823_M01-AddTableInfoUser')
BEGIN
    CREATE TABLE [InfoUser] (
        [IdInfo] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        [DtNasc] datetime2 NOT NULL,
        [Genero] nvarchar(max) NOT NULL,
        [Telefone] nvarchar(max) NULL,
        [FormAcademica] nvarchar(max) NULL,
        [Biografia] nvarchar(max) NULL,
        [Link] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_InfoUser] PRIMARY KEY ([IdInfo])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240517124823_M01-AddTableInfoUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240517124823_M01-AddTableInfoUser', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240519194728_M02-AddTableTipoIngrediente')
BEGIN
    CREATE TABLE [TipoIngrediente] (
        [Id] int NOT NULL IDENTITY,
        [Tipo] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TipoIngrediente] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240519194728_M02-AddTableTipoIngrediente')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240519194728_M02-AddTableTipoIngrediente', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240521212556_M01-AddTableReceita')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240521212556_M01-AddTableReceita', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240521232438_M01-AddTableReceita1')
BEGIN
    CREATE TABLE [Receita] (
        [id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        [Ingrediente] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Receita] PRIMARY KEY ([id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240521232438_M01-AddTableReceita1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240521232438_M01-AddTableReceita1', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240522173958_M07-AddTableUsuario')
BEGIN
    CREATE TABLE [Usuario] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Senha] nvarchar(max) NOT NULL,
        [Perfil] int NOT NULL,
        CONSTRAINT [PK_Usuario] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240522173958_M07-AddTableUsuario')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240522173958_M07-AddTableUsuario', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240522174244_M07-AddTableUsuarios')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240522174244_M07-AddTableUsuarios', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601184046_AddM06-AddTableCardapio')
BEGIN
    CREATE TABLE [Cardapio] (
        [Id] int NOT NULL IDENTITY,
        [Descricao] nvarchar(max) NOT NULL,
        [CaloriasCardapio] int NOT NULL,
        [Quantidade] int NOT NULL,
        CONSTRAINT [PK_Cardápio] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601184046_AddM06-AddTableCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240601184046_AddM06-AddTableCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601185236_AddM07AddTableCardapio')
BEGIN
    CREATE TABLE [Cardapio] (
        [Id] int NOT NULL IDENTITY,
        [Descricao] nvarchar(max) NOT NULL,
        [CaloriasCardapio] int NOT NULL,
        [Quantidade] int NOT NULL,
        CONSTRAINT [PK_Cardápio] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601185236_AddM07AddTableCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240601185236_AddM07AddTableCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601204459_AddFKTableCardapiodeUsuario')
BEGIN
    ALTER TABLE [Cardapio] ADD [UsuarioId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601204459_AddFKTableCardapiodeUsuario')
BEGIN
    CREATE INDEX [IX_Cardapio_UsuarioId] ON [Cardapio] ([UsuarioId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601204459_AddFKTableCardapiodeUsuario')
BEGIN
    ALTER TABLE [Cardapio] ADD CONSTRAINT [FK_Cardapio_Usuario_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuario] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601204459_AddFKTableCardapiodeUsuario')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240601204459_AddFKTableCardapiodeUsuario', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601210751_AddFKIngredienteToCardapio')
BEGIN
    ALTER TABLE [Cardapio] ADD [IngredienteId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601210751_AddFKIngredienteToCardapio')
BEGIN
    CREATE INDEX [IX_Cardapio_IngredienteId] ON [Cardapio] ([IngredienteId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601210751_AddFKIngredienteToCardapio')
BEGIN
    ALTER TABLE [Cardapio] ADD CONSTRAINT [FK_Cardapio_Ingrediente_IngredienteId] FOREIGN KEY ([IngredienteId]) REFERENCES [Ingrediente] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240601210751_AddFKIngredienteToCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240601210751_AddFKIngredienteToCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240602170153_Atualiza')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240602170153_Atualiza', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240602200409_AddEmailTableUsuario')
BEGIN
    ALTER TABLE [Usuario] ADD [Email] nvarchar(max) NOT NULL DEFAULT N'';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240602200409_AddEmailTableUsuario')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240602200409_AddEmailTableUsuario', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240602210249_correcaocardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240602210249_correcaocardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240602214010_CaloriaCardapio')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Cardapio]') AND [c].[name] = N'CaloriasCardapio');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Cardapio] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Cardapio] DROP COLUMN [CaloriasCardapio];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240602214010_CaloriaCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240602214010_CaloriaCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603134539_NovoBD')
BEGIN
    CREATE TABLE [Ingrediente] (
        [Id] int NOT NULL IDENTITY,
        CONSTRAINT [PK_Ingrediente] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603134539_NovoBD')
BEGIN
    CREATE TABLE [Cardapio] (
        [Id] int NOT NULL IDENTITY,
        CONSTRAINT [PK_Cardapio] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603134539_NovoBD')
BEGIN
    CREATE TABLE [CardapioIngrediente] (
        [CardapioId] int NOT NULL,
        [IngredientesAssociadosId] int NOT NULL,
        CONSTRAINT [PK_CardapioIngrediente] PRIMARY KEY ([CardapioId], [IngredientesAssociadosId]),
        CONSTRAINT [FK_CardapioIngrediente_Cardapio_CardapioId] FOREIGN KEY ([CardapioId]) REFERENCES [Cardapio] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_CardapioIngrediente_Ingrediente_IngredientesAssociadosId] FOREIGN KEY ([IngredientesAssociadosId]) REFERENCES [Ingrediente] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603134539_NovoBD')
BEGIN
    CREATE INDEX [IX_CardapioIngrediente_IngredientesAssociadosId] ON [CardapioIngrediente] ([IngredientesAssociadosId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603134539_NovoBD')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603134539_NovoBD', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603140827_AtualizacaoCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603140827_AtualizacaoCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603152936_ad-migration AtuaizacaTaeIngredint')
BEGIN
    CREATE TABLE [TipoIngrediente] (
        [Id] int NOT NULL IDENTITY,
        [Tipo] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TipoIngrediente] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603152936_ad-migration AtuaizacaTaeIngredint')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603152936_ad-migration AtuaizacaTaeIngredint', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603154133_AddTableIngrediente')
BEGIN
    CREATE TABLE [Ingrediente] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        [Calorias] int NOT NULL,
        [Unidade] nvarchar(max) NOT NULL,
        [Peso] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Ingrediente] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603154133_AddTableIngrediente')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603154133_AddTableIngrediente', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603155337_AddTableCardapio')
BEGIN
    CREATE TABLE [Cardapio] (
        [Id] int NOT NULL IDENTITY,
        [Descricao] nvarchar(max) NOT NULL,
        [CaloriasCardapio] int NOT NULL,
        [Quantidade] int NOT NULL,
        CONSTRAINT [PK_Cardápio] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603155337_AddTableCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603155337_AddTableCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603160404_AddTipoTableIngrediente')
BEGIN
    ALTER TABLE [Ingrediente] ADD [Tipo] nvarchar(max) NOT NULL DEFAULT N'';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603160404_AddTipoTableIngrediente')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603160404_AddTipoTableIngrediente', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603160746_AddFKTableIngrediente')
BEGIN
    ALTER TABLE [Ingrediente] ADD [TipoIngredienteId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603160746_AddFKTableIngrediente')
BEGIN
    CREATE INDEX [IX_Ingrediente_TipoIngredienteId] ON [Ingrediente] ([TipoIngredienteId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603160746_AddFKTableIngrediente')
BEGIN
    ALTER TABLE [Ingrediente] ADD CONSTRAINT [FK_Ingrediente_TipoIngrediente_TipoIngredienteId] FOREIGN KEY ([TipoIngredienteId]) REFERENCES [TipoIngrediente] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603160746_AddFKTableIngrediente')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603160746_AddFKTableIngrediente', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603161114_AddFKUsuarioTableCardapio')
BEGIN
    ALTER TABLE [Cardapio] ADD [UsuarioId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603161114_AddFKUsuarioTableCardapio')
BEGIN
    CREATE INDEX [IX_Cardapio_UsuarioId] ON [Cardapio] ([UsuarioId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603161114_AddFKUsuarioTableCardapio')
BEGIN
    ALTER TABLE [Cardapio] ADD CONSTRAINT [FK_Cardapio_Usuario_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuario] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603161114_AddFKUsuarioTableCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603161114_AddFKUsuarioTableCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603161331_AddFKIngredienteTableCardapio')
BEGIN
    ALTER TABLE [Cardapio] ADD [IngredienteId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603161331_AddFKIngredienteTableCardapio')
BEGIN
    CREATE INDEX [IX_Cardapio_IngredienteId] ON [Cardapio] ([IngredienteId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603161331_AddFKIngredienteTableCardapio')
BEGIN
    ALTER TABLE [Cardapio] ADD CONSTRAINT [FK_Cardapio_Ingrediente_IngredienteId] FOREIGN KEY ([IngredienteId]) REFERENCES [Ingrediente] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240603161331_AddFKIngredienteTableCardapio')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240603161331_AddFKIngredienteTableCardapio', N'6.0.29');
END;
GO

COMMIT;
GO

