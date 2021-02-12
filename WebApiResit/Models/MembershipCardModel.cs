using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApiResit.Models
{
    public class MembershipCardModel
    {


        public int ID
        {
            get;
            set;
        }



        public string MembershipCardCode
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string MembershipCardFee
        {
            get;
            set;
        }


        public string MembershipCardType
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }




        public string ExpiredDate
        {
            get;
            set;
        }

        public string MembershipCardBackgroundImg
        {
            get;
            set;
        }


        public string CreatedDate
        {
            get;
            set;
        }




        public string CreatedBy
        {
            get;
            set;
        }





        public string StartDate
        {
            get;
            set;
        }


        public string MembershipCardName
        {
            get;
            set;
        }

        public string MembershipCardFeePaymentCycle
        {
            get;
            set;
        }

        public string StrExpiredDate
        {
            get;
            set;
        }

        public string isValidLifeTime
        {
            get;
            set;
        }
        public string ModifiedBy
        {
            get;
            set;
        }

      public string ModifiedDate
        {
            get;
            set;
        }

      public string MembershipCardBackgroundImgName
        {
            get;
            set;
        }

        
      public MembershipCardModel() { }

        //test
         
     
	


      public static string AdvertisementImages_InsertUpdate(int ID, string MembershipCardCode, string EnterpriseAccNo,
          string MembershipCardFee, string MembershipCardType, string ExpiredDate, string MembershipCardBackgroundImg, 
          string CreatedBy, string StartDate,string MembershipCardName,string MembershipCardFeePaymentCycle,string StrExpiredDate,
          string isValidLifeTime, string MembershipCardBackgroundImgName)
      {

          SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
          string _value = "true";
          using (SqlConnection _DBConnection = _SQLConnection)
          {
              SqlCommand _SQLCommand = new SqlCommand();
              _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
              _SQLCommand.CommandTimeout = 0;
              using (_SQLCommand)
              {
                  try
                  {
                      _SQLCommand.Connection = _DBConnection;
                      _SQLCommand.CommandText = "AdvertisementImages_InsertUpdate";
                      _SQLCommand.Parameters.AddWithValue("@ID", ID);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardFee", MembershipCardFee);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardType", MembershipCardType);
                      _SQLCommand.Parameters.AddWithValue("@ExpiredDate", ExpiredDate);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardBackgroundImg", "http://42.1.63.57/AyohaImgCard/MembershipCardBackgroundImg/" + EnterpriseAccNo + "/" + MembershipCardBackgroundImgName);
                      _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                      _SQLCommand.Parameters.AddWithValue("@StartDate", StartDate);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardName", MembershipCardName);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardFeePaymentCycle", MembershipCardFeePaymentCycle);
                      _SQLCommand.Parameters.AddWithValue("@StrExpiredDate", StrExpiredDate);
                      _SQLCommand.Parameters.AddWithValue("@isValidLifeTime", isValidLifeTime);
                   
                      _DBConnection.Open();
                      _SQLCommand.ExecuteNonQuery();
                  }

                  catch (Exception ex)
                  {
                      _value = "false," + ex.ToString(); ;
                      // _value = ex.ToString();
                  }

                  finally
                  {

                      _DBConnection.Close();

                      if (MembershipCardBackgroundImg != "ExistingImage")
                      {
                          MembershipCardBackground_CreateImg(MembershipCardBackgroundImg, EnterpriseAccNo, MembershipCardBackgroundImgName);
                      }
                  }

              }

          }



          return _value;
      }

      public static void MembershipCardBackground_CreateImg(string ImgStr, string AccountNo, string ImageName)
      {



          //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
          String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\MembershipCardBackgroundImg\\" + AccountNo + "\\";//Path
          //string NameImg = ImgName;
          //Check if directory exist
          if (!System.IO.Directory.Exists(dirPath))
          {
              System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
          }
          // string ImgPath = "";
          if (ImgStr.Contains("data:image"))
          {

              string[] namesArray = ImgStr.Split(',');
              string n = namesArray[1];
              // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
              // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
              String imgNames = ImageName;
              //ImgPath = "http://42.1.63.57/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + imgNames;



              byte[] imgByteArray = Convert.FromBase64String(n);
              File.WriteAllBytes(dirPath + imgNames, imgByteArray);
          }

         
      }


    }
















      
}