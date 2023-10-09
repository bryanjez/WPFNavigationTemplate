Electronic Secretary Office Management System
Electronic Secretary Office Management System

# About

**Schema:**

>**Users**
   1. username
   2. password
   3. email
   4. firstname
   5. middlename
   6. lastname
   7. phone_number
   8. address
   9. emergency_contact_name
   10. emergency_contact_phone
   11. assigned_type
        - SP 
        - BM 
        - CO 
        - VG
        - VM 
   12. user_type
        - Superadmin
        - Admin
        - Staff
        - Secretary
   13. level (All level can update their profile) [1,2,3,4,5, any]
        - 1 (Search)
        - 2 (View)
        - 3 (Upload) - (Upload documents)
        - 4 (Process request) - (Permission to process request)
        - 4a (request) - (You can add request) (can be applied to BM/VG/CO Staff)
        - 4ab (request) - (You can add request and approved request) (can be applied to SP Staff)
        - any (any Permission)
        
> - Sample 1: level: [1,2,3] (Search, view and upload permission only)
> - Sample 2: level: [any] (no need to add more if you have any Permission)
> - Sample 3: level: [4] (You have permission to process request like saving request)
> - Sample 4: level: [4a] (You have permission to process request like saving request) 
> - Sample 4: level: [4ab] (You have permission to process request like saving request and approved the request) 

>**Default level permission**
- SP -> Secretary [any]
- SP -> Admin [1,2,3,4,4ab]
- SP -> Staff [1,2,3]
- BM/CO/VG/VM -> Admin [1,2,3,4a]
- BM/CO/VG/VM -> Staff [1,2]
- Superadmin - GODMODE





