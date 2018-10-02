using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models
{
    [Table("Users")]
    public class UserModel : BaseModel, IBaseModel<UserModel>
    {
        [Required]
        [DisplayName("Name")]
        public string NickName { get => Name; set => Name = value; }
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Required]
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Passwd { get; protected set; }
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string ValPasswd { get; set; }
        [DisplayName("Token")]
        public string Token { get; set; }
        [DisplayName("Cookie")]
        public string Cookie { get; set; }

        [DisplayName("Valid until")]
        public DateTime? Valid { get; set; }
        [DisplayName("Agree to all Terms")]
        public bool AgreeToAllTerms { get; set; }
        [DisplayName("Terms")]
        public string Terms { get; set; }

        public bool IsValidPasswd(string passwd)
        {
            passwd = libs.Security.Hash32(passwd, Unique);
            return Passwd == passwd;
        }

        /// <summary>
        /// Validate the password in ValPasswd.
        /// </summary>
        /// <returns></returns>
        public bool IsValidPasswd()
        {
            var passwd = libs.Security.Hash32(ValPasswd, Unique);
            return Passwd == passwd;
        }

        public void AddPasswd(string passwd)
        {
            if (!libs.Security.IsPasswdRequeriments(passwd))
                throw new Exception("This is password not contains minimun security request");

            Passwd = libs.Security.Hash32(passwd, Unique);
        }

        public void Update(UserModel model)
        {
            base.Update(model);
            FullName = model.FullName;
            Email = model.Email;
            Phone = model.Phone;
            Passwd = model.Passwd;
            Token = model.Token;
            Valid = model.Valid;

        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<UserModel>();
            e.HasIndex(t => t.Email).IsUnique();
            e.Ignore(t => t.ValPasswd);
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new UserModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
