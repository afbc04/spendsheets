# Summary

- **Title:** Undraft a Draft Entry
- **Description:** Administrators can undraft draft entries
- **Pre-condition:** User must be Administrator & entry must exists and be in DRAFT mode
- **Pos-condition:** Entry's information is updated

# Flow

### Normal Flow

1. User initiates the undrafting draft entries process.
2. User selects the entry
3. System updates the draft entry, updating:
    - Status to PENDING _(If Multiple Payment or Saving)_ or DONE _(If Single Payment)_
    - Update last change date
    - Indicates this entry is not draft