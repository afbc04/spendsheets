# Summary

- **Title:** Edit Config
- **Description:** User can update informations about config
- **Pre-condition:** Config must exists and User must be Administrator
- **Pos-condition:** Config's informations are updated

# Flow

### Normal Flow

1. User initiates the edit config process.
2. User indicates the new information of the config, such as:
    - Name
    - Username
    - Password
    - Is visible to public?
    - Initial money
    - Life days of trash
3. System validates the new informations
4. System saves the changes of the config

### Exception (3) [Informations are invalid]

3.1. System informs the information provided is invalid
