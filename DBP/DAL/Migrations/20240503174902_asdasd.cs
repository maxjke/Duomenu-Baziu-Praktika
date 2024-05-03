using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Migrations
{
    public partial class asdasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Consultation_ConsultationId",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_ContactInfo_ContactInfoId",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Course_CourseId",
                table: "Teacher");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "CourseSources");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Lecture");

            migrationBuilder.DropTable(
                name: "InformationSource");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Consultation");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_ContactInfoId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_CourseId",
                table: "Teacher");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Entity");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_ConsultationId",
                table: "Entity",
                newName: "IX_Entity_ConsultationId");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Entity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContactInfoId",
                table: "Entity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ConsultationId",
                table: "Entity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Advertisement_CourseId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingInformationId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardHolderName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CareerCenterId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertificateDegree",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertificateName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Certificate_CourseId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certificate_ExpireDate",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyDescription",
                table: "Entity",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsultationDate",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Consultation_Duration",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Consultation_StudentId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Consultation_TeacherId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Entity",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpireDate",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GradeValue",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Grade_StudentId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Group_CourseId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InformationSourceId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InformationSourceName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InformationSourceType",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LectureDate",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LectureName",
                table: "Entity",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LectureTime",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lecture_CourseId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lecture_Description",
                table: "Entity",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfferInformation",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethodName",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Entity",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Teacher_ConsultationId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Teacher_ContactInfoId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Teacher_CourseId",
                table: "Entity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "Entity",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entity",
                table: "Entity",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Advertisement_CourseId",
                table: "Entity",
                column: "Advertisement_CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_BillingInformationId",
                table: "Entity",
                column: "BillingInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_CareerCenterId",
                table: "Entity",
                column: "CareerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Certificate_CourseId",
                table: "Entity",
                column: "Certificate_CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_CompanyId",
                table: "Entity",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_ContactInfoId",
                table: "Entity",
                column: "ContactInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_CourseId",
                table: "Entity",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Grade_StudentId",
                table: "Entity",
                column: "Grade_StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Group_CourseId",
                table: "Entity",
                column: "Group_CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_GroupId",
                table: "Entity",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_InformationSourceId",
                table: "Entity",
                column: "InformationSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Lecture_CourseId",
                table: "Entity",
                column: "Lecture_CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_OrderId",
                table: "Entity",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_ScheduleId",
                table: "Entity",
                column: "ScheduleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Teacher_ConsultationId",
                table: "Entity",
                column: "Teacher_ConsultationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Teacher_ContactInfoId",
                table: "Entity",
                column: "Teacher_ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Teacher_CourseId",
                table: "Entity",
                column: "Teacher_CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_TeacherId",
                table: "Entity",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_Advertisement_CourseId",
                table: "Entity",
                column: "Advertisement_CourseId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_BillingInformationId",
                table: "Entity",
                column: "BillingInformationId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_CareerCenterId",
                table: "Entity",
                column: "CareerCenterId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_Certificate_CourseId",
                table: "Entity",
                column: "Certificate_CourseId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_CompanyId",
                table: "Entity",
                column: "CompanyId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_ConsultationId",
                table: "Entity",
                column: "ConsultationId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_ContactInfoId",
                table: "Entity",
                column: "ContactInfoId",
                principalTable: "Entity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_CourseId",
                table: "Entity",
                column: "CourseId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_Grade_StudentId",
                table: "Entity",
                column: "Grade_StudentId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_Group_CourseId",
                table: "Entity",
                column: "Group_CourseId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_GroupId",
                table: "Entity",
                column: "GroupId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_InformationSourceId",
                table: "Entity",
                column: "InformationSourceId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_Lecture_CourseId",
                table: "Entity",
                column: "Lecture_CourseId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_OrderId",
                table: "Entity",
                column: "OrderId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_ScheduleId",
                table: "Entity",
                column: "ScheduleId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_Teacher_ConsultationId",
                table: "Entity",
                column: "Teacher_ConsultationId",
                principalTable: "Entity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_Teacher_ContactInfoId",
                table: "Entity",
                column: "Teacher_ContactInfoId",
                principalTable: "Entity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_Teacher_CourseId",
                table: "Entity",
                column: "Teacher_CourseId",
                principalTable: "Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_Entity_TeacherId",
                table: "Entity",
                column: "TeacherId",
                principalTable: "Entity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_Advertisement_CourseId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_BillingInformationId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_CareerCenterId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_Certificate_CourseId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_CompanyId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_ConsultationId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_ContactInfoId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_CourseId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_Grade_StudentId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_Group_CourseId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_GroupId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_InformationSourceId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_Lecture_CourseId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_OrderId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_ScheduleId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_Teacher_ConsultationId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_Teacher_ContactInfoId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_Teacher_CourseId",
                table: "Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_Entity_Entity_TeacherId",
                table: "Entity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entity",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Advertisement_CourseId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_BillingInformationId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_CareerCenterId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Certificate_CourseId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_CompanyId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_ContactInfoId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_CourseId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Grade_StudentId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Group_CourseId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_GroupId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_InformationSourceId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Lecture_CourseId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_OrderId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_ScheduleId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Teacher_ConsultationId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Teacher_ContactInfoId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Teacher_CourseId",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_TeacherId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Advertisement_CourseId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "BillingInformationId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CardHolderName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CareerCenterId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CertificateDegree",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CertificateName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Certificate_CourseId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Certificate_ExpireDate",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CompanyDescription",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "ConsultationDate",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Consultation_Duration",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Consultation_StudentId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Consultation_TeacherId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "GradeValue",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Grade_StudentId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Group_CourseId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "InformationSourceId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "InformationSourceName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "InformationSourceType",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "LectureDate",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "LectureName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "LectureTime",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Lecture_CourseId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Lecture_Description",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "OfferInformation",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "PaymentMethodName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Teacher_ConsultationId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Teacher_ContactInfoId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Teacher_CourseId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "Entity");

            migrationBuilder.RenameTable(
                name: "Entity",
                newName: "Teacher");

            migrationBuilder.RenameIndex(
                name: "IX_Entity_ConsultationId",
                table: "Teacher",
                newName: "IX_Teacher_ConsultationId");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactInfoId",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConsultationId",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Consultation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ConsultationDate = table.Column<string>(type: "longtext", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TeacherId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "longtext", nullable: false),
                    City = table.Column<string>(type: "longtext", nullable: false),
                    Country = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInfo_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CourseName = table.Column<string>(type: "longtext", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InformationSource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    InformationSourceName = table.Column<string>(type: "longtext", nullable: false),
                    InformationSourceType = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationSource", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LectureDate = table.Column<string>(type: "longtext", nullable: false),
                    LectureTime = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisement_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CertificateDegree = table.Column<string>(type: "longtext", nullable: false),
                    CertificateName = table.Column<string>(type: "longtext", nullable: false),
                    ExpireDate = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificate_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CourseSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InformationSourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSources_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSources_InformationSource_InformationSourceId",
                        column: x => x.InformationSourceId,
                        principalTable: "InformationSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lecture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    LectureName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Video = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lecture_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lecture_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ConsultationId = table.Column<int>(type: "int", nullable: false),
                    ContactInfoId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Consultation_ConsultationId",
                        column: x => x.ConsultationId,
                        principalTable: "Consultation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_ContactInfo_ContactInfoId",
                        column: x => x.ContactInfoId,
                        principalTable: "ContactInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    GradeValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grade_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_ContactInfoId",
                table: "Teacher",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_CourseId",
                table: "Teacher",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_CourseId",
                table: "Advertisement",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_CourseId",
                table: "Certificate",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_TeacherId",
                table: "ContactInfo",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSources_CourseId",
                table: "CourseSources",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSources_InformationSourceId",
                table: "CourseSources",
                column: "InformationSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_StudentId",
                table: "Grade",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_CourseId",
                table: "Group",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lecture_CourseId",
                table: "Lecture",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecture_ScheduleId",
                table: "Lecture",
                column: "ScheduleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_ConsultationId",
                table: "Student",
                column: "ConsultationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_ContactInfoId",
                table: "Student",
                column: "ContactInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupId",
                table: "Student",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Consultation_ConsultationId",
                table: "Teacher",
                column: "ConsultationId",
                principalTable: "Consultation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_ContactInfo_ContactInfoId",
                table: "Teacher",
                column: "ContactInfoId",
                principalTable: "ContactInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Course_CourseId",
                table: "Teacher",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
