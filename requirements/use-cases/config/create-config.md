# Summary

- **Title:** Create Config
- **Description:** Create config to be used in program
- **Pre-condition:** Config must be empty
- **Pos-condition:** Config is created

# Flow

### Normal Flow

1. User initiates the creating config process.
2. User provides information, such as:
    - Name of user _(Optional)_
    - Username
    - Password
    - Is visible to public? _(Optional)_
    - Initial money _(Optional)_
    - Lost money _(Optional)_
    - Saved money _(Optional)_
3. System validates the information provided
4. System fills the missing information, such as:
    - Last open date is the current date
    - If no value provided to visibility, default value is false
    - If no initial money is not provided, sets it as 0
    - If no lost money is not provided, sets it as 0
    - If no saved money is not provided, sets it as 0
5. System saves the config

### Exception (3) [Information is invalid]

3.1. System informs to user that information provided is invalid