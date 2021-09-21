public class User
{

    private String name; 
    private int id;
    private String  email;
    private String  mobile;
    private String  password;
    private String  role;
    private String  status; 
    

    public user(String name)
    {
        this.name = name;
    }      

    public String getName() 
    {

    return Name;
    }

    public void setName(String name) 
    {

            Name = name;
    }
    public String getEmail() 
    {
            return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getMobile() {
        return mobile;
    }

    public void setMobile(String mobile) {
        this.mobile = mobile;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public int getId() {
        
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
}