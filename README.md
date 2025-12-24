# Deploy

### Prerequisites
- Docker
- Docker Compose

### 1. Cloning Project

    git clone git@github.com:afbc04/spendsheets.git

    cd spendsheets/

### 2. Setup Project

    touch .env

Variables should have this format:

```
```

### 3. Building

    docker compose build

### 4. Starting

    docker compose up -d

### 5. Cleaning

    docker compose down

### Extra Usage

# Report

`INSERT SUMMARY HERE`

## 0. Index

## 1. Introduction

### 1.1. Contextualization

This project has the objective to be an useful and complete project made by me.  
Managing the usage of money it's important, therefore this project was born to help with it.

### 1.2. Motivation & objectives

The main problems with money management are:
- Keeping track of money borrowed
- Keeping track of unpaid loans or services
- Noticing where the money is spent, leading to realization some bad usage


To help with those problems, this project:
- Saves loans and it's movements, informing if they are finished and how much money is still required
- Saves money transitions, making a history of money spent or received
- With help of tags and categories, entries can be grouped up
- Display statistics related to these entries, helping the management of money usage

### Project Identity

### Development Plan

## 2. Requirements

### Funcional Requirements

#### 1. Config

**Configuration** informs how the system should behave, giving ways to obtain access tokens

| File | Description |
|------|--------------|
| [getting-token.md](use-cases/config/getting-token.md) | Obtain the access token |
| [change-to-reader-token.md](use-cases/config/change-to-reader-token.md) | Switches token's reader mode |
| [deleteting-token.md](use-cases/config/deleteting-token.md) | Delete the access token |
| [create-config.md](use-cases/config/create-config.md) | Configure the system |
| [config-details.md](use-cases/config/config-details.md) | View configuration details |
| [edit-config.md](use-cases/config/edit-config.md) | Edit configuration |
| [update-entries.md](use-cases/config/update-entries.md) | Update entries when system boots up |

#### 2. Classifiers

**Category** helps to split entries into different categories

| File | Description |
|------|------------|
| [add-category.md](use-cases/category/add-category.md) | Create a new category |
| [category-details.md](use-cases/category/category-details.md) | Get category details |
| [delete-category.md](use-cases/category/delete-category.md) | Delete an existing category |
| [edit-category.md](use-cases/category/edit-category.md) | Edit a category |
| [list-categories.md](use-cases/category/list-categories.md) | List all categories |

**Tag** helps to group entries

| File | Description |
|------|------------|
| [add-tag.md](use-cases/tags/add-tag.md) | Create a tag |
| [edit-tag.md](use-cases/tags/edit-tag.md) | Edit a tag |
| [delete-tag.md](use-cases/tags/delete-tag.md) | Delete a tag |
| [list-tags.md](use-cases/tags/list-tags.md) | List all tags |
| [tag-details.md](use-cases/tags/tag-details.md) | View tag details |

#### 3. Monthly Services

**Monthly Services** helps the system automatically generating entries

| File | Description |
|------|------------|
| [add-service.md](use-cases/monthly-service/add-service.md) | Add a monthly service |
| [edit-service.md](use-cases/monthly-service/edit-service.md) | Edit a monthly service |
| [delete-service.md](use-cases/monthly-service/delete-service.md) | Delete a monthly service |
| [list-services.md](use-cases/monthly-service/list-services.md) | List monthly services |
| [service-details.md](use-cases/monthly-service/service-details.md) | View monthly service details |

#### 4. Statistics

**Statistics** provides informations about loads of entities of the system

_Loads of statistics will be dealt soon_

| File | Description |
|------|------------|
| [general-infos.md](use-cases/statistic/general-infos.md) | General statistics |
| [entries-infos.md](use-cases/statistic/entries-infos.md) | Entry-related statistics |
| [money-infos.md](use-cases/statistic/money-infos.md) | Financial statistics |

#### 5. Entries

**Entries** are the main protagonist, being all different entries treated the same way

| File | Description |
|------|------------|
| [create-entry.md](use-cases/entries/create-entry.md) | Create a new entry |
| [edit-entry.md](use-cases/entries/edit-entry.md) | Edit an entry |
| [delete-entry.md](use-cases/entries/delete-entry.md) | Delete an entry |
| [entry-details.md](use-cases/entries/entry-details.md) | View entry details |
| [list-entries.md](use-cases/entries/list-entries.md) | List all entries |
| [finish-entry.md](use-cases/entries/finish-entry.md) | Mark an entry as finished |
| [recover-entry-from-trash.md](use-cases/entries/recover-entry-from-trash.md) | Restore deleted entry |
| [changing-saving-status.md](use-cases/entries/changing-saving-status.md) | Change saving status |
| [undrafting-a-draft.md](use-cases/entries/undrafting-a-draft.md) | Convert draft to active entry |
| [add-line.md](use-cases/entries/add-line.md) | Add a line to an entry |
| [edit-line.md](use-cases/entries/edit-line.md) | Edit an entry line |
| [delete-line.md](use-cases/entries/delete-line.md) | Delete an entry line |
| [add-note.md](use-cases/entries/add-note.md) | Add a note to an entry |
| [edit-note.md](use-cases/entries/edit-note.md) | Edit an entry note |
| [remove-note.md](use-cases/entries/remove-note.md) | Remove an entry note |
| [add-tag.md](use-cases/entries/add-tag.md) | Add a tag to an entry |
| [delete-tag.md](use-cases/entries/delete-tag.md) | Remove a tag from an entry |

### Non-Functional Requirements

The system shall:
- Efficiently handle a high volume of read operations
- Support write operations performed by a single user, without requiring concurrency handling
- Securely store user passwords using encryption
- Be flexible and maintainable, allowing adaptation to future updates or changes.
- Operate primarily in offline mode, becoming online only when explicitly activated by the system owner
- Scale to support a large number of entries without performance degradation
- Provide acceptable response times for all supported operations

## 3. System Design

## 4. Database

```
# Dataset

## Config

- Last Open Date
- Name of user
- Username
- password
- Is visible to public?
- Init money
- Lost money
- Saved money

## Movement

- ID
- Money Added _(Is negative number, money was removed)_
- Date
- Comment

## Notes

- ID
- Note
- Date

## Category

- ID
- When was created
- Name
- Description

## Monthly Service

- ID
- When was created
- Name
- Description
- Category Related
- Money amount
- is active?

## Tag

- ID
- Name
- Description

## Entries

### Final Format

- ID
- ID of Category
- ID of Monthly Services
- Is visible?
- Type:
    - Transaction
    - Multiple Payments
    - Saving
- ID of initial movement
- Date of last change
- Was generated by system?
- List of tags
- List of movements
- Is it a draft?
- Date of Creation of entry
- Date of Finish of entry
- Begin Date
- Scheduled Due Date
- Real Due Date
- Description
- List of notes
- Status:
    - DRAFT
    - SCHEDULED
    - PENDING
    - COMPLETED
    - DONE
    - DELETED
    - CANCELLED
    - IGNORED
    - ONGOING
    - OVERDUE
    - CORRUPTED

    - STALLED
    - ACCOMPLISHED

### Deleted Entries

- Deletion Date of entry
```

## 5. Business Logic

## 6. User Interfaces

## 7. Usage

## 8. Testing

## 9. Conclusion