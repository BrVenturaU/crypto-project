﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoProjectApi.Migrations
{
    public partial class Change_Data_From_Log_Password_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 109, 6, 174, 236, 228, 62, 171, 84, 79, 195, 125, 72, 97, 198, 240, 76, 60, 61, 250, 151, 81, 20, 179, 185, 91, 158, 4, 33, 15, 66, 56, 95, 226, 51, 227, 254, 195, 43, 136, 31, 254, 47, 145, 24, 31, 42, 221, 207, 224, 3, 183, 229, 211, 26, 147, 237, 221, 84, 187, 145, 80, 0, 16, 237 }, new byte[] { 75, 55, 57, 60, 26, 63, 218, 45, 193, 241, 137, 113, 46, 72, 166, 70, 222, 27, 135, 173, 214, 185, 225, 27, 245, 71, 22, 30, 12, 96, 50, 156, 53, 94, 206, 224, 21, 126, 64, 238, 254, 77, 49, 233, 234, 170, 231, 179, 42, 80, 206, 160, 79, 97, 168, 157, 87, 186, 0, 226, 16, 1, 189, 48, 154, 194, 195, 128, 35, 187, 4, 16, 245, 81, 202, 12, 58, 98, 214, 109, 112, 27, 74, 252, 39, 11, 233, 107, 183, 239, 112, 71, 243, 3, 133, 132, 72, 231, 101, 84, 233, 104, 217, 243, 217, 6, 14, 65, 246, 94, 137, 225, 92, 106, 123, 1, 194, 3, 248, 5, 239, 226, 153, 138, 237, 108, 80, 49 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 152, 82, 82, 43, 55, 49, 14, 90, 3, 247, 73, 225, 252, 206, 18, 223, 75, 143, 253, 2, 119, 155, 81, 241, 240, 76, 91, 107, 20, 212, 112, 100, 88, 154, 196, 222, 131, 24, 160, 124, 56, 225, 57, 184, 136, 41, 68, 212, 62, 117, 230, 52, 18, 169, 75, 246, 93, 48, 174, 26, 230, 111, 62, 215 }, new byte[] { 126, 34, 179, 197, 52, 200, 186, 142, 59, 231, 183, 123, 151, 249, 70, 76, 116, 196, 77, 210, 80, 95, 135, 196, 132, 240, 227, 40, 135, 134, 219, 144, 123, 188, 213, 85, 191, 17, 41, 128, 10, 251, 121, 17, 49, 217, 55, 45, 221, 181, 108, 106, 250, 40, 60, 10, 98, 30, 18, 28, 192, 117, 118, 202, 154, 62, 93, 27, 100, 129, 123, 20, 145, 201, 133, 183, 126, 83, 249, 121, 201, 215, 208, 211, 123, 44, 69, 87, 212, 239, 216, 45, 54, 201, 141, 68, 181, 91, 177, 7, 238, 187, 177, 191, 94, 27, 202, 41, 255, 67, 41, 136, 182, 116, 167, 43, 246, 151, 230, 177, 177, 33, 133, 91, 61, 112, 248, 75 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 85, 41, 240, 107, 97, 116, 33, 119, 142, 235, 173, 179, 164, 128, 48, 201, 234, 102, 149, 91, 90, 100, 50, 117, 88, 213, 88, 147, 155, 159, 154, 110, 87, 136, 173, 91, 46, 72, 27, 32, 80, 6, 189, 147, 59, 239, 51, 17, 142, 212, 183, 240, 254, 117, 195, 118, 93, 248, 239, 163, 108, 110, 72, 235 }, new byte[] { 194, 42, 56, 186, 233, 52, 94, 140, 213, 198, 180, 217, 135, 120, 127, 2, 53, 38, 137, 98, 46, 38, 158, 75, 49, 201, 229, 126, 110, 85, 211, 198, 86, 68, 181, 232, 124, 185, 154, 247, 100, 130, 26, 5, 103, 235, 75, 37, 194, 79, 167, 73, 144, 156, 61, 4, 141, 81, 205, 8, 113, 51, 116, 53, 97, 7, 190, 91, 36, 175, 130, 197, 137, 248, 1, 123, 27, 59, 247, 250, 67, 162, 244, 73, 213, 72, 57, 39, 247, 77, 98, 1, 21, 131, 1, 22, 119, 6, 103, 215, 31, 147, 24, 138, 113, 138, 198, 27, 42, 218, 56, 107, 186, 168, 251, 76, 27, 206, 77, 175, 10, 162, 90, 213, 101, 16, 47, 124 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 168, 65, 109, 106, 191, 64, 163, 211, 121, 183, 148, 144, 98, 7, 63, 232, 31, 198, 67, 109, 106, 62, 128, 137, 170, 119, 180, 132, 245, 161, 131, 44, 251, 221, 90, 231, 5, 118, 33, 107, 45, 254, 21, 176, 253, 119, 129, 199, 138, 10, 132, 34, 198, 180, 144, 142, 239, 76, 179, 15, 234, 211, 248, 95 }, new byte[] { 75, 197, 252, 153, 111, 251, 204, 17, 223, 156, 169, 79, 11, 38, 150, 98, 104, 8, 132, 21, 107, 89, 79, 129, 8, 56, 135, 212, 57, 78, 29, 5, 40, 14, 124, 147, 199, 215, 21, 26, 128, 110, 239, 171, 140, 189, 193, 190, 29, 34, 165, 216, 99, 105, 18, 26, 128, 38, 99, 184, 254, 112, 184, 28, 205, 96, 204, 179, 165, 233, 84, 252, 77, 210, 231, 194, 130, 131, 135, 214, 191, 131, 35, 75, 6, 149, 13, 41, 47, 169, 44, 72, 90, 240, 240, 227, 30, 224, 230, 221, 52, 65, 64, 237, 214, 216, 29, 28, 85, 246, 67, 8, 160, 217, 9, 234, 237, 28, 45, 207, 21, 206, 74, 20, 61, 213, 242, 10 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 123, 220, 176, 173, 0, 145, 74, 197, 106, 90, 24, 69, 191, 231, 77, 65, 50, 232, 119, 153, 51, 115, 6, 63, 210, 1, 23, 169, 221, 224, 70, 218, 16, 180, 54, 3, 133, 17, 140, 90, 100, 105, 61, 38, 30, 63, 144, 85, 216, 205, 35, 138, 111, 71, 105, 229, 198, 36, 6, 15, 169, 85, 117, 197 }, new byte[] { 145, 126, 33, 121, 136, 125, 4, 6, 196, 84, 157, 187, 33, 141, 80, 177, 234, 202, 196, 36, 151, 142, 25, 217, 30, 199, 17, 162, 223, 222, 190, 173, 78, 199, 8, 81, 169, 62, 181, 141, 196, 114, 14, 135, 202, 22, 200, 79, 12, 91, 132, 2, 241, 144, 94, 228, 198, 29, 145, 178, 4, 9, 218, 151, 119, 248, 163, 46, 52, 158, 93, 121, 204, 19, 47, 13, 138, 15, 113, 148, 42, 100, 230, 13, 195, 106, 108, 95, 212, 61, 183, 52, 30, 165, 42, 174, 180, 68, 220, 199, 75, 191, 164, 140, 170, 162, 215, 14, 33, 192, 98, 65, 207, 23, 229, 82, 126, 193, 243, 237, 83, 206, 205, 65, 131, 71, 191, 191 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hash",
                value: new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 2,
                column: "Hash",
                value: new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 3,
                column: "Hash",
                value: new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 4,
                column: "Hash",
                value: new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 5,
                column: "Hash",
                value: new byte[] { 255, 23, 127, 218, 174, 100, 215, 61 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 37, 86, 167, 186, 58, 22, 61, 140, 244, 3, 141, 9, 89, 212, 93, 136, 42, 79, 41, 142, 212, 3, 33, 21, 202, 145, 195, 165, 175, 54, 163, 14, 90, 26, 25, 75, 49, 22, 80, 169, 206, 141, 186, 110, 128, 85, 187, 174, 155, 27, 7, 224, 76, 138, 72, 5, 76, 201, 132, 97, 68, 141, 146, 208 }, new byte[] { 150, 8, 132, 3, 14, 214, 139, 210, 253, 126, 166, 110, 10, 171, 34, 109, 78, 201, 20, 115, 186, 38, 179, 34, 22, 225, 98, 159, 77, 143, 112, 92, 139, 161, 95, 108, 249, 234, 247, 248, 163, 55, 160, 120, 148, 104, 135, 98, 235, 45, 36, 233, 237, 146, 124, 11, 208, 77, 142, 62, 188, 245, 219, 63, 50, 152, 105, 48, 8, 185, 141, 26, 64, 134, 187, 17, 137, 39, 173, 101, 162, 127, 18, 231, 245, 103, 154, 139, 45, 145, 196, 134, 244, 11, 150, 156, 202, 117, 30, 45, 220, 1, 91, 79, 30, 60, 102, 127, 81, 160, 132, 76, 254, 183, 148, 241, 21, 153, 92, 220, 76, 252, 176, 217, 197, 152, 132, 228 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 18, 229, 164, 204, 4, 190, 163, 35, 127, 126, 167, 248, 165, 132, 49, 122, 153, 86, 80, 174, 236, 14, 233, 151, 139, 195, 226, 85, 28, 170, 43, 243, 144, 227, 252, 166, 184, 1, 127, 197, 225, 208, 159, 135, 17, 176, 14, 77, 23, 234, 98, 28, 233, 226, 69, 21, 194, 13, 2, 124, 17, 89, 227, 225 }, new byte[] { 181, 75, 100, 47, 124, 3, 130, 176, 241, 210, 197, 120, 87, 233, 69, 175, 80, 55, 93, 8, 85, 81, 64, 78, 127, 87, 39, 93, 149, 31, 30, 187, 156, 130, 125, 125, 161, 144, 89, 148, 189, 142, 54, 174, 67, 126, 217, 140, 183, 165, 43, 134, 98, 29, 153, 128, 46, 183, 74, 246, 200, 101, 0, 182, 160, 130, 38, 76, 191, 185, 9, 73, 52, 85, 244, 58, 111, 113, 223, 100, 56, 37, 69, 155, 109, 141, 119, 207, 93, 99, 241, 240, 101, 205, 18, 165, 244, 55, 221, 208, 62, 138, 227, 36, 6, 197, 32, 137, 16, 222, 231, 195, 57, 135, 43, 154, 150, 161, 98, 141, 194, 33, 56, 201, 26, 134, 48, 173 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 199, 139, 213, 57, 12, 165, 238, 68, 157, 31, 119, 172, 20, 14, 116, 250, 70, 254, 131, 208, 152, 135, 134, 94, 125, 88, 226, 13, 163, 172, 157, 156, 176, 90, 178, 156, 92, 126, 75, 185, 81, 68, 56, 174, 37, 139, 225, 90, 147, 148, 127, 185, 251, 249, 169, 251, 46, 2, 45, 105, 126, 64, 62, 52 }, new byte[] { 81, 230, 33, 147, 116, 5, 164, 43, 238, 26, 70, 35, 206, 105, 39, 113, 43, 192, 253, 140, 95, 1, 6, 192, 168, 40, 7, 205, 44, 134, 145, 114, 207, 119, 237, 118, 19, 191, 139, 84, 30, 35, 125, 234, 216, 255, 30, 34, 118, 121, 217, 154, 237, 53, 93, 154, 176, 77, 147, 57, 241, 42, 109, 225, 248, 3, 33, 71, 176, 166, 68, 178, 203, 137, 33, 124, 235, 241, 246, 58, 229, 140, 8, 134, 69, 169, 206, 227, 99, 44, 102, 45, 76, 246, 128, 70, 132, 43, 98, 247, 104, 244, 250, 37, 176, 16, 77, 166, 229, 241, 166, 210, 250, 214, 134, 170, 247, 67, 166, 48, 242, 186, 4, 126, 236, 45, 138, 98 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 52, 216, 84, 197, 125, 56, 97, 62, 62, 79, 189, 245, 115, 224, 112, 29, 170, 123, 231, 150, 68, 123, 210, 124, 71, 92, 56, 111, 113, 210, 165, 9, 213, 75, 92, 22, 38, 217, 171, 237, 65, 158, 2, 210, 139, 151, 106, 116, 69, 76, 51, 122, 57, 56, 247, 175, 222, 235, 124, 59, 86, 75, 94, 5 }, new byte[] { 221, 148, 62, 51, 104, 56, 31, 157, 158, 17, 135, 168, 177, 62, 133, 6, 168, 94, 173, 22, 68, 230, 31, 194, 40, 189, 85, 226, 243, 52, 44, 239, 170, 244, 151, 73, 163, 32, 49, 63, 22, 61, 35, 121, 119, 227, 188, 120, 229, 84, 70, 183, 101, 244, 84, 120, 134, 239, 205, 59, 52, 229, 2, 46, 111, 156, 144, 233, 173, 212, 182, 76, 168, 62, 236, 252, 150, 145, 77, 93, 12, 93, 203, 6, 117, 138, 36, 145, 54, 160, 33, 237, 44, 180, 78, 136, 95, 22, 138, 252, 71, 86, 233, 10, 34, 172, 49, 227, 121, 19, 142, 88, 155, 138, 92, 156, 162, 122, 195, 40, 93, 194, 129, 1, 155, 72, 238, 18 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithSalt",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { new byte[] { 172, 245, 11, 136, 111, 118, 183, 70, 12, 112, 228, 193, 198, 108, 165, 156, 252, 173, 108, 241, 24, 114, 254, 154, 235, 250, 253, 77, 150, 172, 30, 134, 245, 245, 190, 64, 23, 203, 154, 178, 189, 204, 244, 253, 13, 230, 229, 92, 55, 88, 169, 203, 84, 97, 185, 65, 219, 219, 215, 182, 114, 245, 149, 234 }, new byte[] { 19, 103, 234, 255, 196, 38, 195, 8, 248, 238, 202, 119, 162, 139, 129, 214, 225, 1, 92, 26, 204, 67, 198, 183, 234, 145, 139, 163, 185, 171, 66, 112, 244, 186, 82, 177, 65, 147, 125, 34, 83, 121, 216, 169, 5, 159, 215, 83, 124, 151, 190, 25, 144, 175, 207, 175, 163, 162, 197, 152, 135, 93, 41, 64, 160, 161, 236, 234, 111, 200, 53, 1, 166, 183, 231, 74, 242, 229, 232, 29, 4, 5, 131, 226, 130, 74, 86, 23, 171, 200, 66, 76, 82, 217, 40, 15, 129, 119, 145, 50, 206, 104, 43, 57, 77, 113, 118, 146, 59, 180, 214, 247, 30, 52, 252, 152, 223, 212, 168, 90, 121, 31, 150, 96, 161, 229, 180, 2 } });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hash",
                value: new byte[] { 37, 86, 167, 186, 58, 22, 61, 140, 244, 3, 141, 9, 89, 212, 93, 136, 42, 79, 41, 142, 212, 3, 33, 21, 202, 145, 195, 165, 175, 54, 163, 14, 90, 26, 25, 75, 49, 22, 80, 169, 206, 141, 186, 110, 128, 85, 187, 174, 155, 27, 7, 224, 76, 138, 72, 5, 76, 201, 132, 97, 68, 141, 146, 208 });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 2,
                column: "Hash",
                value: new byte[] { 18, 229, 164, 204, 4, 190, 163, 35, 127, 126, 167, 248, 165, 132, 49, 122, 153, 86, 80, 174, 236, 14, 233, 151, 139, 195, 226, 85, 28, 170, 43, 243, 144, 227, 252, 166, 184, 1, 127, 197, 225, 208, 159, 135, 17, 176, 14, 77, 23, 234, 98, 28, 233, 226, 69, 21, 194, 13, 2, 124, 17, 89, 227, 225 });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 3,
                column: "Hash",
                value: new byte[] { 199, 139, 213, 57, 12, 165, 238, 68, 157, 31, 119, 172, 20, 14, 116, 250, 70, 254, 131, 208, 152, 135, 134, 94, 125, 88, 226, 13, 163, 172, 157, 156, 176, 90, 178, 156, 92, 126, 75, 185, 81, 68, 56, 174, 37, 139, 225, 90, 147, 148, 127, 185, 251, 249, 169, 251, 46, 2, 45, 105, 126, 64, 62, 52 });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 4,
                column: "Hash",
                value: new byte[] { 52, 216, 84, 197, 125, 56, 97, 62, 62, 79, 189, 245, 115, 224, 112, 29, 170, 123, 231, 150, 68, 123, 210, 124, 71, 92, 56, 111, 113, 210, 165, 9, 213, 75, 92, 22, 38, 217, 171, 237, 65, 158, 2, 210, 139, 151, 106, 116, 69, 76, 51, 122, 57, 56, 247, 175, 222, 235, 124, 59, 86, 75, 94, 5 });

            migrationBuilder.UpdateData(
                table: "PasswordLogsWithoutSalt",
                keyColumn: "Id",
                keyValue: 5,
                column: "Hash",
                value: new byte[] { 172, 245, 11, 136, 111, 118, 183, 70, 12, 112, 228, 193, 198, 108, 165, 156, 252, 173, 108, 241, 24, 114, 254, 154, 235, 250, 253, 77, 150, 172, 30, 134, 245, 245, 190, 64, 23, 203, 154, 178, 189, 204, 244, 253, 13, 230, 229, 92, 55, 88, 169, 203, 84, 97, 185, 65, 219, 219, 215, 182, 114, 245, 149, 234 });
        }
    }
}