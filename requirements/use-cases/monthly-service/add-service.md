# Summary

- **Title:** Add Monthly Service
- **Description:** Administrators can create categories
- **Pre-condition:** User must be Administrator
- **Pos-condition:** System has a new category

# Flow

### Normal Flow

1. User initiates the add monthly service process.
2. User provides:
    - Name
    - Description _(Optional)_
    - Type
    - Category Related _(Optional)_
    - Monthly amount _(Optional)_
    - Is active? _(Optional)_
3. System validates the information provided
4. System determines the ID and Creation Date of new monthly service
5. If user does not indicated if monthly service is active, the system assumes its active
6. System saves the new monthly service, providing the ID to the user 

### Exception (3) [Information is invalid]

3.1. System informs to user that information provided is invalid
