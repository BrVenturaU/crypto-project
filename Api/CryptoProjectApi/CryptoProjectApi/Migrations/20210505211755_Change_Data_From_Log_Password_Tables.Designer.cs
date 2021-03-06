// <auto-generated />
using System;
using CryptoProjectApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CryptoProjectApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210505211755_Change_Data_From_Log_Password_Tables")]
    partial class Change_Data_From_Log_Password_Tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CryptoProjectApi.Entity.PasswordLogWithSalt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Hash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("PasswordLogsWithSalt");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Hash = new byte[] { 109, 6, 174, 236, 228, 62, 171, 84, 79, 195, 125, 72, 97, 198, 240, 76, 60, 61, 250, 151, 81, 20, 179, 185, 91, 158, 4, 33, 15, 66, 56, 95, 226, 51, 227, 254, 195, 43, 136, 31, 254, 47, 145, 24, 31, 42, 221, 207, 224, 3, 183, 229, 211, 26, 147, 237, 221, 84, 187, 145, 80, 0, 16, 237 },
                            Salt = new byte[] { 75, 55, 57, 60, 26, 63, 218, 45, 193, 241, 137, 113, 46, 72, 166, 70, 222, 27, 135, 173, 214, 185, 225, 27, 245, 71, 22, 30, 12, 96, 50, 156, 53, 94, 206, 224, 21, 126, 64, 238, 254, 77, 49, 233, 234, 170, 231, 179, 42, 80, 206, 160, 79, 97, 168, 157, 87, 186, 0, 226, 16, 1, 189, 48, 154, 194, 195, 128, 35, 187, 4, 16, 245, 81, 202, 12, 58, 98, 214, 109, 112, 27, 74, 252, 39, 11, 233, 107, 183, 239, 112, 71, 243, 3, 133, 132, 72, 231, 101, 84, 233, 104, 217, 243, 217, 6, 14, 65, 246, 94, 137, 225, 92, 106, 123, 1, 194, 3, 248, 5, 239, 226, 153, 138, 237, 108, 80, 49 }
                        },
                        new
                        {
                            Id = 2,
                            Hash = new byte[] { 152, 82, 82, 43, 55, 49, 14, 90, 3, 247, 73, 225, 252, 206, 18, 223, 75, 143, 253, 2, 119, 155, 81, 241, 240, 76, 91, 107, 20, 212, 112, 100, 88, 154, 196, 222, 131, 24, 160, 124, 56, 225, 57, 184, 136, 41, 68, 212, 62, 117, 230, 52, 18, 169, 75, 246, 93, 48, 174, 26, 230, 111, 62, 215 },
                            Salt = new byte[] { 126, 34, 179, 197, 52, 200, 186, 142, 59, 231, 183, 123, 151, 249, 70, 76, 116, 196, 77, 210, 80, 95, 135, 196, 132, 240, 227, 40, 135, 134, 219, 144, 123, 188, 213, 85, 191, 17, 41, 128, 10, 251, 121, 17, 49, 217, 55, 45, 221, 181, 108, 106, 250, 40, 60, 10, 98, 30, 18, 28, 192, 117, 118, 202, 154, 62, 93, 27, 100, 129, 123, 20, 145, 201, 133, 183, 126, 83, 249, 121, 201, 215, 208, 211, 123, 44, 69, 87, 212, 239, 216, 45, 54, 201, 141, 68, 181, 91, 177, 7, 238, 187, 177, 191, 94, 27, 202, 41, 255, 67, 41, 136, 182, 116, 167, 43, 246, 151, 230, 177, 177, 33, 133, 91, 61, 112, 248, 75 }
                        },
                        new
                        {
                            Id = 3,
                            Hash = new byte[] { 85, 41, 240, 107, 97, 116, 33, 119, 142, 235, 173, 179, 164, 128, 48, 201, 234, 102, 149, 91, 90, 100, 50, 117, 88, 213, 88, 147, 155, 159, 154, 110, 87, 136, 173, 91, 46, 72, 27, 32, 80, 6, 189, 147, 59, 239, 51, 17, 142, 212, 183, 240, 254, 117, 195, 118, 93, 248, 239, 163, 108, 110, 72, 235 },
                            Salt = new byte[] { 194, 42, 56, 186, 233, 52, 94, 140, 213, 198, 180, 217, 135, 120, 127, 2, 53, 38, 137, 98, 46, 38, 158, 75, 49, 201, 229, 126, 110, 85, 211, 198, 86, 68, 181, 232, 124, 185, 154, 247, 100, 130, 26, 5, 103, 235, 75, 37, 194, 79, 167, 73, 144, 156, 61, 4, 141, 81, 205, 8, 113, 51, 116, 53, 97, 7, 190, 91, 36, 175, 130, 197, 137, 248, 1, 123, 27, 59, 247, 250, 67, 162, 244, 73, 213, 72, 57, 39, 247, 77, 98, 1, 21, 131, 1, 22, 119, 6, 103, 215, 31, 147, 24, 138, 113, 138, 198, 27, 42, 218, 56, 107, 186, 168, 251, 76, 27, 206, 77, 175, 10, 162, 90, 213, 101, 16, 47, 124 }
                        },
                        new
                        {
                            Id = 4,
                            Hash = new byte[] { 168, 65, 109, 106, 191, 64, 163, 211, 121, 183, 148, 144, 98, 7, 63, 232, 31, 198, 67, 109, 106, 62, 128, 137, 170, 119, 180, 132, 245, 161, 131, 44, 251, 221, 90, 231, 5, 118, 33, 107, 45, 254, 21, 176, 253, 119, 129, 199, 138, 10, 132, 34, 198, 180, 144, 142, 239, 76, 179, 15, 234, 211, 248, 95 },
                            Salt = new byte[] { 75, 197, 252, 153, 111, 251, 204, 17, 223, 156, 169, 79, 11, 38, 150, 98, 104, 8, 132, 21, 107, 89, 79, 129, 8, 56, 135, 212, 57, 78, 29, 5, 40, 14, 124, 147, 199, 215, 21, 26, 128, 110, 239, 171, 140, 189, 193, 190, 29, 34, 165, 216, 99, 105, 18, 26, 128, 38, 99, 184, 254, 112, 184, 28, 205, 96, 204, 179, 165, 233, 84, 252, 77, 210, 231, 194, 130, 131, 135, 214, 191, 131, 35, 75, 6, 149, 13, 41, 47, 169, 44, 72, 90, 240, 240, 227, 30, 224, 230, 221, 52, 65, 64, 237, 214, 216, 29, 28, 85, 246, 67, 8, 160, 217, 9, 234, 237, 28, 45, 207, 21, 206, 74, 20, 61, 213, 242, 10 }
                        },
                        new
                        {
                            Id = 5,
                            Hash = new byte[] { 123, 220, 176, 173, 0, 145, 74, 197, 106, 90, 24, 69, 191, 231, 77, 65, 50, 232, 119, 153, 51, 115, 6, 63, 210, 1, 23, 169, 221, 224, 70, 218, 16, 180, 54, 3, 133, 17, 140, 90, 100, 105, 61, 38, 30, 63, 144, 85, 216, 205, 35, 138, 111, 71, 105, 229, 198, 36, 6, 15, 169, 85, 117, 197 },
                            Salt = new byte[] { 145, 126, 33, 121, 136, 125, 4, 6, 196, 84, 157, 187, 33, 141, 80, 177, 234, 202, 196, 36, 151, 142, 25, 217, 30, 199, 17, 162, 223, 222, 190, 173, 78, 199, 8, 81, 169, 62, 181, 141, 196, 114, 14, 135, 202, 22, 200, 79, 12, 91, 132, 2, 241, 144, 94, 228, 198, 29, 145, 178, 4, 9, 218, 151, 119, 248, 163, 46, 52, 158, 93, 121, 204, 19, 47, 13, 138, 15, 113, 148, 42, 100, 230, 13, 195, 106, 108, 95, 212, 61, 183, 52, 30, 165, 42, 174, 180, 68, 220, 199, 75, 191, 164, 140, 170, 162, 215, 14, 33, 192, 98, 65, 207, 23, 229, 82, 126, 193, 243, 237, 83, 206, 205, 65, 131, 71, 191, 191 }
                        });
                });

            modelBuilder.Entity("CryptoProjectApi.Entity.PasswordLogWithoutSalt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Hash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("PasswordLogsWithoutSalt");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Hash = new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 }
                        },
                        new
                        {
                            Id = 2,
                            Hash = new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 }
                        },
                        new
                        {
                            Id = 3,
                            Hash = new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 }
                        },
                        new
                        {
                            Id = 4,
                            Hash = new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 }
                        },
                        new
                        {
                            Id = 5,
                            Hash = new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 }
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
