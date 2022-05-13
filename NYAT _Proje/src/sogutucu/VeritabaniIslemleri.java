
package sogutucu;
import java.sql.*;
import java.io.FileWriter;

import java.io.IOException;

import java.io.PrintWriter;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class VeritabaniIslemleri {
    
     private static VeritabaniIslemleri instance;
     private String kullaniciAdi= null;
     private String kullaniciId=null;
     private String sifre=null;
     private static List kisiler = new ArrayList(); 
     private static List sifreler = new ArrayList(); 
     private static List idler = new ArrayList(); 
     
   private VeritabaniIslemleri()
   {
       try
        {  
            
            Connection conn = DriverManager.getConnection("jdbc:postgresql://localhost:5432/Sogutucu",
                    "postgres", "Tt1245678*");
            if (conn != null)
                System.out.println("Veri tabanýna baðlanýldý!");
            else
                System.out.println("Veri tabanýna baðlanýlamadý!");

            String sql= "SELECT \"kullanici_adi\", \"kullanici_id\", \"sifre\"  FROM \"internet_kullanicisi\"";

            Statement stmt = conn.createStatement();
            ResultSet rs = stmt.executeQuery(sql);
            
            conn.close();

            

            while(rs.next())
            {
                kullaniciAdi  = rs.getString("kullanici_adi");
                kullaniciId= rs.getString("kullanici_id");
                sifre = rs.getString("sifre");
                
                kisiler.add(kullaniciAdi); 
                sifreler.add(sifre); 
                idler.add(kullaniciId);
            }
            
            rs.close();
            stmt.close();

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
   
    public static synchronized VeritabaniIslemleri getInstance(){

            if(instance==null)

                instance = new VeritabaniIslemleri();

        return instance;
    
}
    
public List KisiIdGonder()
{
  return idler;
}


    public static boolean kullaniciDogrula(String kullaniciadi, String sifre) {
        
      VeritabaniIslemleri vtys= new VeritabaniIslemleri();
        System.out.println("Veritabani dogrulama sistemi kullanýcýyý doðruluyor...");
         try {
                            Thread.sleep(1000);
                    } catch (InterruptedException e) {
                            e.printStackTrace();
                    }

        
        
  for(int i=0;i<kisiler.size();i++) { 
                	 
             if(kullaniciadi.compareTo((String)(kisiler.get(i)))==0&&sifre.compareTo((String)(sifreler.get(i)))==0)
             {
                 System.out.println(kullaniciadi+ " "+ sifre+"   Kullanýcý doðrulandý");
                  try {
                            Thread.sleep(1000);
                    } catch (InterruptedException e) {
                            e.printStackTrace();
                    }
                  return true;
             }
            
         }

      return false;

    }

  
}