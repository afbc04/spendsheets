# Summary

- **Title:** Edit Monthly Service
- **Description:** Administrators can edit existing categories
- **Pre-condition:** User must be Administrator & Monthly Service must exists
- **Pos-condition:** Monthly Service's information is updated

# Flow

### Normal Flow

1. User initiates the edit Monthly Service process.
2. User selects the Monthly Service
3. User provides the new information, such as:
    - Name of Monthly Service
    - Description of Monthly Service
    - Category related of Monthly Service
    - Money amount
    - Is active?
4. System validates the information provided
5. System updates the Monthly Service

### Exception (4) [Information is invalid]

5. System informs to user that information provided is invalid
