# Summary

- **Title:** Category Details
- **Description:** The system gives details related to a category
- **Pre-condition:** Category must exists
- **Pos-condition:** Category's details are shown

# Flow

### Normal Flow

1. User initiates the category details process.
2. System provides informations about this category, such as:
    - ID
    - Name
    - Description
    - When was created
    - Is sub category?
    - ID of parent category
    - Type

### Alternative Flow (2) [Category is Monthly Service]

2.1. System also provides more information, such as:
    - Monthly amount
    - Is monthly service active?

### Alternative Flow (2) [Category is Parent Category and user wants to see its children]

2.1. System also provides more information, such as:
    - List of categories children
