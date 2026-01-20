# Script de Migration - Base de Données EXAMEN

## 📋 Description

Ce script de migration (`Migration_Complete.sql`) recrée entièrement la base de données **EXAMEN** pour le système de gestion de vente de billets.

## ✨ Fonctionnalités

Le script effectue automatiquement :

1. **Suppression** des objets existants (tables, vues, procédures)
2. **Création** de toutes les tables avec leurs contraintes
3. **Insertion** des données de base (catégories, salles, spectacles, clients, agents, etc.)
4. **Création** de toutes les procédures stockées
5. **Création** de toutes les vues nécessaires (y compris celles manquantes)

## 🚀 Utilisation

### Prérequis

- SQL Server installé et en cours d'exécution
- Base de données `EXAMEN` créée (vide ou existante)
- Permissions suffisantes pour créer/supprimer des objets

### Étapes d'exécution

1. **Créer la base de données** (si elle n'existe pas) :
   ```sql
   CREATE DATABASE EXAMEN;
   GO
   ```

2. **Exécuter le script de migration** :
   - Ouvrir SQL Server Management Studio (SSMS)
   - Ouvrir le fichier `Migration_Complete.sql`
   - Vérifier que la base de données `EXAMEN` est sélectionnée
   - Cliquer sur **Exécuter** (F5)

   Ou via la ligne de commande :
   ```bash
   sqlcmd -S localhost -d EXAMEN -i Migration_Complete.sql
   ```

## 📊 Contenu créé

### Tables (9)
- `tCategorie` - Catégories de places (Basique, VIP)
- `tSalle` - Salles de spectacle
- `tClients` - Clients
- `tAgents` - Agents/Vendeurs avec authentification
- `tSpectacle` - Spectacles
- `tPlace` - Places dans les salles
- `tPaiement` - Paiements
- `tFacture` - Factures
- `tBillets` - Billets vendus

### Procédures stockées (9)
- `sp_SaveOrUpdateClient_Flexible` - Gestion clients
- `sp_SaveOrUpdateAgent_Flexible` - Gestion agents
- `SaveOrUpdateSalle` - Gestion salles
- `SaveOrUpdateSpectacle` - Gestion spectacles
- `SaveOrUpdatePlace` - Gestion places
- `SaveOrUpdatePaiement` - Gestion paiements
- `SaveOrUpdateFacture` - Gestion factures
- `SaveOrUpdateBillet` - Gestion billets
- `Production_Facture` - Production de factures

### Vues (6)
- `Affichez_Facture` - Vue des factures avec détails
- `Produire_Recu` - Vue pour les reçus
- `Imprmez_Billet` - Vue pour l'impression des billets
- `Affichez_Agent` - Vue des agents (pour recherche)
- `Affichez_Billet` - Vue des billets (pour recherche)
- `Affichez_Paiement` - Vue des paiements (pour recherche)

## 👤 Comptes par défaut

Trois comptes sont créés avec le mot de passe **1234** :

| Username | Fonction | Rôle |
|----------|----------|------|
| `admin` | Admin Principal | Gerant |
| `masela` | Agent Masela | Vendeur |
| `makambo` | Agent Makambo | Compable |

## ⚠️ Avertissements

- **Ce script supprime toutes les données existantes** avant de recréer la structure
- Assurez-vous d'avoir une sauvegarde si vous avez des données importantes
- Le script est idempotent : vous pouvez l'exécuter plusieurs fois sans problème

## 🔄 Réexécution

Le script peut être réexécuté à tout moment. Il supprimera d'abord tous les objets existants avant de les recréer, garantissant un état propre de la base de données.

## 📝 Notes

- Les mots de passe sont stockés en clair (1234) - à modifier en production
- Les données de démonstration sont incluses pour faciliter les tests
- Toutes les vues nécessaires au fonctionnement de l'application C# sont créées

## 🐛 Dépannage

Si vous rencontrez des erreurs :

1. Vérifiez que la base de données `EXAMEN` existe
2. Vérifiez que vous avez les permissions nécessaires
3. Vérifiez qu'aucune connexion active n'utilise les objets à supprimer
4. Consultez les messages d'erreur dans la fenêtre de résultats SQL

## 📞 Support

Pour toute question ou problème, vérifiez :
- La compatibilité avec votre version de SQL Server
- Les logs d'erreur dans SSMS
- La configuration de la chaîne de connexion dans `App.config`
