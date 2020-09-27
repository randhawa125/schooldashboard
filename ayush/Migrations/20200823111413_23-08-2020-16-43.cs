using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ayush.Migrations
{
    public partial class _230820201643 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AddCounsellor_FirstName = table.Column<string>(nullable: true),
                    AddCounsellor_LastName = table.Column<string>(nullable: true),
                    AddCounsellor_Designation = table.Column<string>(nullable: true),
                    AddCounsellor_Address = table.Column<string>(nullable: true),
                    AddSchool_FirstName = table.Column<string>(nullable: true),
                    AddSchool_LastName = table.Column<string>(nullable: true),
                    AddSchool_Designation = table.Column<string>(nullable: true),
                    AddSchool_Address = table.Column<string>(nullable: true),
                    AddStudent_FirstName = table.Column<string>(nullable: true),
                    AddStudent_LastName = table.Column<string>(nullable: true),
                    Class2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    PersonalityFactors = table.Column<string>(nullable: true),
                    AptitudeFactors = table.Column<string>(nullable: true),
                    EQFactors = table.Column<string>(nullable: true),
                    InterestFactors = table.Column<string>(nullable: true),
                    MotivatorFactors = table.Column<string>(nullable: true),
                    StenPersonalityFactors = table.Column<string>(nullable: true),
                    StenAptitudeFactors = table.Column<string>(nullable: true),
                    StenEQFactors = table.Column<string>(nullable: true),
                    StenMotivatorFactors = table.Column<string>(nullable: true),
                    StenInterestFactors = table.Column<string>(nullable: true),
                    PersonalityStenConstant1 = table.Column<decimal>(nullable: false),
                    PersonalityStenConstant2 = table.Column<decimal>(nullable: false),
                    PersonalityStenConstant3 = table.Column<decimal>(nullable: false),
                    PersonalityStenConstant4 = table.Column<decimal>(nullable: false),
                    AptitudeStenConstant1 = table.Column<decimal>(nullable: false),
                    AptitudeStenConstant2 = table.Column<decimal>(nullable: false),
                    AptitudeStenConstant3 = table.Column<decimal>(nullable: false),
                    AptitudeStenConstant4 = table.Column<decimal>(nullable: false),
                    EQStenConstant1 = table.Column<decimal>(nullable: false),
                    EQStenConstant2 = table.Column<decimal>(nullable: false),
                    EQStenConstant3 = table.Column<decimal>(nullable: false),
                    EQStenConstant4 = table.Column<decimal>(nullable: false),
                    InterestStenConstant1 = table.Column<decimal>(nullable: false),
                    InterestStenConstant2 = table.Column<decimal>(nullable: false),
                    InterestStenConstant3 = table.Column<decimal>(nullable: false),
                    InterestStenConstant4 = table.Column<decimal>(nullable: false),
                    MotivatorStenConstant1 = table.Column<decimal>(nullable: false),
                    MotivatorStenConstant2 = table.Column<decimal>(nullable: false),
                    MotivatorStenConstant3 = table.Column<decimal>(nullable: false),
                    MotivatorStenConstant4 = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    WereInstructionsClear = table.Column<string>(nullable: false),
                    WasEngaging = table.Column<string>(nullable: false),
                    WasEasyToUnderstand = table.Column<string>(nullable: false),
                    ModulesConcernWith = table.Column<string>(nullable: true),
                    DifficultyLevelFine = table.Column<string>(nullable: false),
                    WhichModulesDifficult = table.Column<string>(nullable: true),
                    OverallExperience = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterestModuleQuestion6UserCareers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    CareerDataId = table.Column<string>(nullable: true),
                    CareerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestModuleQuestion6UserCareers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterestModuleQuestion7UserCareers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    CareerDataId = table.Column<string>(nullable: true),
                    CareerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestModuleQuestion7UserCareers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterestModuleQuestion8UserCareers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    CareerDataId = table.Column<string>(nullable: true),
                    CareerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestModuleQuestion8UserCareers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OneTimePasswords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(maxLength: 50, nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    IsKeyUsed = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneTimePasswords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassiveCareers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareerListType = table.Column<int>(nullable: false, defaultValue: 1),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    PersonalityFactors = table.Column<string>(nullable: true),
                    AptitudeFactors = table.Column<string>(nullable: true),
                    EQFactors = table.Column<string>(nullable: true),
                    InterestFactors = table.Column<string>(nullable: true),
                    MotivatorFactors = table.Column<string>(nullable: true),
                    StenPersonalityFactors = table.Column<string>(nullable: true),
                    StenAptitudeFactors = table.Column<string>(nullable: true),
                    StenEQFactors = table.Column<string>(nullable: true),
                    StenMotivatorFactors = table.Column<string>(nullable: true),
                    StenInterestFactors = table.Column<string>(nullable: true),
                    PersonalityStenConstant1 = table.Column<decimal>(nullable: false),
                    PersonalityStenConstant2 = table.Column<decimal>(nullable: false),
                    PersonalityStenConstant3 = table.Column<decimal>(nullable: false),
                    PersonalityStenConstant4 = table.Column<decimal>(nullable: false),
                    AptitudeStenConstant1 = table.Column<decimal>(nullable: false),
                    AptitudeStenConstant2 = table.Column<decimal>(nullable: false),
                    AptitudeStenConstant3 = table.Column<decimal>(nullable: false),
                    AptitudeStenConstant4 = table.Column<decimal>(nullable: false),
                    EQStenConstant1 = table.Column<decimal>(nullable: false),
                    EQStenConstant2 = table.Column<decimal>(nullable: false),
                    EQStenConstant3 = table.Column<decimal>(nullable: false),
                    EQStenConstant4 = table.Column<decimal>(nullable: false),
                    InterestStenConstant1 = table.Column<decimal>(nullable: false),
                    InterestStenConstant2 = table.Column<decimal>(nullable: false),
                    InterestStenConstant3 = table.Column<decimal>(nullable: false),
                    InterestStenConstant4 = table.Column<decimal>(nullable: false),
                    MotivatorStenConstant1 = table.Column<decimal>(nullable: false),
                    MotivatorStenConstant2 = table.Column<decimal>(nullable: false),
                    MotivatorStenConstant3 = table.Column<decimal>(nullable: false),
                    MotivatorStenConstant4 = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassiveCareers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TimeDuration = table.Column<TimeSpan>(nullable: false),
                    EnableQuizTimer = table.Column<bool>(nullable: false),
                    EnableQuestionTimer = table.Column<bool>(nullable: false),
                    OwnerID = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentModuleFiveMarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    SelfAwareness = table.Column<decimal>(nullable: false),
                    SelfRegulation = table.Column<decimal>(nullable: false),
                    SelfExpression = table.Column<decimal>(nullable: false),
                    IntrinsicMotivation = table.Column<decimal>(nullable: false),
                    Empathy = table.Column<decimal>(nullable: false),
                    RelationshipManagement = table.Column<decimal>(nullable: false),
                    ConflictManagement = table.Column<decimal>(nullable: false),
                    FinalStenSelfAwareness = table.Column<decimal>(nullable: false),
                    FinalStenSelfRegulation = table.Column<decimal>(nullable: false),
                    FinalStenSelfExpression = table.Column<decimal>(nullable: false),
                    FinalStenIntrinsicMotivation = table.Column<decimal>(nullable: false),
                    FinalStenEmpathy = table.Column<decimal>(nullable: false),
                    FinalStenRelationshipManagement = table.Column<decimal>(nullable: false),
                    FinalStenConflictManagement = table.Column<decimal>(nullable: false),
                    Intrinsic = table.Column<decimal>(nullable: false),
                    Extrinsic = table.Column<decimal>(nullable: false),
                    OverallValues = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModuleFiveMarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentModuleFourMarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    VerbalReasoning = table.Column<decimal>(nullable: false),
                    CriticalThinking = table.Column<decimal>(nullable: false),
                    AbstractReasoning = table.Column<decimal>(nullable: false),
                    SpatialReasoning = table.Column<decimal>(nullable: false),
                    QuantitativeReasoning = table.Column<decimal>(nullable: false),
                    AttentionToDetail = table.Column<decimal>(nullable: false),
                    PerceptualReasoning = table.Column<decimal>(nullable: false),
                    MechanicalReasoning = table.Column<decimal>(nullable: false),
                    FinalStenVerbalReasoning = table.Column<decimal>(nullable: false),
                    FinalStenCriticalThinking = table.Column<decimal>(nullable: false),
                    FinalStenAbstractReasoning = table.Column<decimal>(nullable: false),
                    FinalStenSpatialReasoning = table.Column<decimal>(nullable: false),
                    FinalStenQuantitativeReasoning = table.Column<decimal>(nullable: false),
                    FinalStenAttentionToDetail = table.Column<decimal>(nullable: false),
                    FinalStenPerceptualReasoning = table.Column<decimal>(nullable: false),
                    FinalStenMechanicalReasoning = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModuleFourMarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentModuleThreeMarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Curiosity = table.Column<decimal>(nullable: false),
                    Tolerance = table.Column<decimal>(nullable: false),
                    OriginalityOfIdeas = table.Column<decimal>(nullable: false),
                    Sociable = table.Column<decimal>(nullable: false),
                    EnergyLevel = table.Column<decimal>(nullable: false),
                    Friendliness = table.Column<decimal>(nullable: false),
                    Optimism = table.Column<decimal>(nullable: false),
                    InternalLocusOfControl = table.Column<decimal>(nullable: false),
                    StressTolerance = table.Column<decimal>(nullable: false),
                    Trusting = table.Column<decimal>(nullable: false),
                    Responsible = table.Column<decimal>(nullable: false),
                    StraightForward = table.Column<decimal>(nullable: false),
                    Cooperative = table.Column<decimal>(nullable: false),
                    AchievementOriented = table.Column<decimal>(nullable: false),
                    RiskTaking = table.Column<decimal>(nullable: false),
                    Perseverance = table.Column<decimal>(nullable: false),
                    Confidence = table.Column<decimal>(nullable: false),
                    Deliberation = table.Column<decimal>(nullable: false),
                    SocialAstuteness = table.Column<decimal>(nullable: false),
                    Proactive = table.Column<decimal>(nullable: false),
                    ActionOriented = table.Column<decimal>(nullable: false),
                    FinalStenCuriosity = table.Column<decimal>(nullable: false),
                    FinalStenTolerance = table.Column<decimal>(nullable: false),
                    FinalStenOriginalityOfIdeas = table.Column<decimal>(nullable: false),
                    FinalStenSociable = table.Column<decimal>(nullable: false),
                    FinalStenEnergyLevel = table.Column<decimal>(nullable: false),
                    FinalStenFriendliness = table.Column<decimal>(nullable: false),
                    FinalStenOptimism = table.Column<decimal>(nullable: false),
                    FinalStenInternalLocusOfControl = table.Column<decimal>(nullable: false),
                    FinalStenStressTolerance = table.Column<decimal>(nullable: false),
                    FinalStenTrusting = table.Column<decimal>(nullable: false),
                    FinalStenResponsible = table.Column<decimal>(nullable: false),
                    FinalStenStraightForward = table.Column<decimal>(nullable: false),
                    FinalStenCooperative = table.Column<decimal>(nullable: false),
                    FinalStenAchievementOriented = table.Column<decimal>(nullable: false),
                    FinalStenRiskTaking = table.Column<decimal>(nullable: false),
                    FinalStenPerseverance = table.Column<decimal>(nullable: false),
                    FinalStenConfidence = table.Column<decimal>(nullable: false),
                    FinalStenDeliberation = table.Column<decimal>(nullable: false),
                    FinalStenSocialAstuteness = table.Column<decimal>(nullable: false),
                    FinalStenProactive = table.Column<decimal>(nullable: false),
                    FinalStenActionOriented = table.Column<decimal>(nullable: false),
                    ExperientialMindset = table.Column<decimal>(nullable: false),
                    Extrovert = table.Column<decimal>(nullable: false),
                    Emotional = table.Column<decimal>(nullable: false),
                    Dependable = table.Column<decimal>(nullable: false),
                    EntrepreneurialMindset = table.Column<decimal>(nullable: false),
                    Opportunistic = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModuleThreeMarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentModuleTwoMarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MoneyAndProfits = table.Column<decimal>(nullable: false),
                    Security = table.Column<decimal>(nullable: false),
                    Networking = table.Column<decimal>(nullable: false),
                    FunLoving = table.Column<decimal>(nullable: false),
                    SocialService = table.Column<decimal>(nullable: false),
                    Recognition = table.Column<decimal>(nullable: false),
                    Power = table.Column<decimal>(nullable: false),
                    Respect = table.Column<decimal>(nullable: false),
                    KnowledgeSeeking = table.Column<decimal>(nullable: false),
                    CreativityAndInnovation = table.Column<decimal>(nullable: false),
                    GoalSetting = table.Column<decimal>(nullable: false),
                    FinalStenMoneyAndProfits = table.Column<decimal>(nullable: false),
                    FinalStenSecurity = table.Column<decimal>(nullable: false),
                    FinalStenNetworking = table.Column<decimal>(nullable: false),
                    FinalStenFunLoving = table.Column<decimal>(nullable: false),
                    FinalStenSocialService = table.Column<decimal>(nullable: false),
                    FinalStenRecognition = table.Column<decimal>(nullable: false),
                    FinalStenPower = table.Column<decimal>(nullable: false),
                    FinalStenRespect = table.Column<decimal>(nullable: false),
                    FinalStenKnowledgeSeeking = table.Column<decimal>(nullable: false),
                    FinalStenCreativityAndInnovation = table.Column<decimal>(nullable: false),
                    FinalStenGoalSetting = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModuleTwoMarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyName = table.Column<string>(maxLength: 50, nullable: false),
                    PropertyValue = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: false),
                    ClassId = table.Column<string>(nullable: true),
                    FeaturedImagePath = table.Column<string>(nullable: true),
                    SubmittedByUserId = table.Column<string>(nullable: true),
                    SubmittedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_AspNetUsers_SubmittedByUserId",
                        column: x => x.SubmittedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentModuleOneMarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Realistic = table.Column<decimal>(nullable: false),
                    Investigative = table.Column<decimal>(nullable: false),
                    Artistic = table.Column<decimal>(nullable: false),
                    Social = table.Column<decimal>(nullable: false),
                    Enterprising = table.Column<decimal>(nullable: false),
                    Conventional = table.Column<decimal>(nullable: false),
                    Outbound_Trainer_or_Corporate_Trainer = table.Column<decimal>(nullable: false),
                    Teaching_Professional = table.Column<decimal>(nullable: false),
                    Environmentalist = table.Column<decimal>(nullable: false),
                    Sales_And_Marketing_Professional = table.Column<decimal>(nullable: false),
                    Actor_or_Art_Director = table.Column<decimal>(nullable: false),
                    Choreographer = table.Column<decimal>(nullable: false),
                    Architect = table.Column<decimal>(nullable: false),
                    Dentist = table.Column<decimal>(nullable: false),
                    Medical_Professional = table.Column<decimal>(nullable: false),
                    Psychologist_or_Counsellor = table.Column<decimal>(nullable: false),
                    Fashion_Designer = table.Column<decimal>(nullable: false),
                    Logistics_And_Operations_Manager = table.Column<decimal>(nullable: false),
                    Police_Officer = table.Column<decimal>(nullable: false),
                    Music_Director_or_Music_Compose_or_Musician = table.Column<decimal>(nullable: false),
                    Painter_or_Illustrator = table.Column<decimal>(nullable: false),
                    Fitness_Trainer_or_sports_Coach = table.Column<decimal>(nullable: false),
                    Stock_Trader = table.Column<decimal>(nullable: false),
                    Gamer = table.Column<decimal>(nullable: false),
                    Chef = table.Column<decimal>(nullable: false),
                    Product_Designer = table.Column<decimal>(nullable: false),
                    Security_Officer = table.Column<decimal>(nullable: false),
                    Airlines_Pilot_or_Commercial_Pilot = table.Column<decimal>(nullable: false),
                    Journalist_or_News_Reporter = table.Column<decimal>(nullable: false),
                    Multimedia_Artist_or_Animator_or_Creative_Director = table.Column<decimal>(nullable: false),
                    Software_Developer = table.Column<decimal>(nullable: false),
                    Financial_Analyst_Investment_Banker_Finanicial_Advisor = table.Column<decimal>(nullable: false),
                    Detective = table.Column<decimal>(nullable: false),
                    Forensic_Scientist = table.Column<decimal>(nullable: false),
                    Artificial_Intelligence_or_Machine_Learning_Expert = table.Column<decimal>(nullable: false),
                    Farming_Expert_or_Agricultural_Scientist = table.Column<decimal>(nullable: false),
                    Disaster_Management_Expert = table.Column<decimal>(nullable: false),
                    Scientist = table.Column<decimal>(nullable: false),
                    Travel_Consultant_Travel_Advisor = table.Column<decimal>(nullable: false),
                    Writer_or_Editor = table.Column<decimal>(nullable: false),
                    Entrepreneur = table.Column<decimal>(nullable: false),
                    Space_Scientist = table.Column<decimal>(nullable: false),
                    Defence_Services = table.Column<decimal>(nullable: false),
                    Hospitality_Services = table.Column<decimal>(nullable: false),
                    Lawyer_Judge = table.Column<decimal>(nullable: false),
                    Mechanical_Engineer = table.Column<decimal>(nullable: false),
                    Social_Worker = table.Column<decimal>(nullable: false),
                    Biologist = table.Column<decimal>(nullable: false),
                    Economist = table.Column<decimal>(nullable: false),
                    Administrative_Services = table.Column<decimal>(nullable: false),
                    Civil_Engineer = table.Column<decimal>(nullable: false),
                    Electric_And_Electronics_Engineer = table.Column<decimal>(nullable: false),
                    Network_Engineer_or_Cyber_Security_Expert = table.Column<decimal>(nullable: false),
                    Data_Scientist = table.Column<decimal>(nullable: false),
                    Public_Relations_Officer = table.Column<decimal>(nullable: false),
                    Event_Manager = table.Column<decimal>(nullable: false),
                    Human_Resources_Manager = table.Column<decimal>(nullable: false),
                    Digital_Marketing_Affiliate_Marketing = table.Column<decimal>(nullable: false),
                    Actuarial_Services = table.Column<decimal>(nullable: false),
                    CA_or_CS = table.Column<decimal>(nullable: false),
                    Wellness_Expert = table.Column<decimal>(nullable: false),
                    Paramedical_Services = table.Column<decimal>(nullable: false),
                    Dietician_or_Nutritionist = table.Column<decimal>(nullable: false),
                    Interior_Designer = table.Column<decimal>(nullable: false),
                    Graphic_Designer = table.Column<decimal>(nullable: false),
                    Photographer = table.Column<decimal>(nullable: false),
                    Blogger = table.Column<decimal>(nullable: false),
                    Customer_Care_Executive = table.Column<decimal>(nullable: false),
                    Copywriter = table.Column<decimal>(nullable: false),
                    Linguistics_Services = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModuleOneMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentModuleOneMarks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSibling",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSibling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSibling_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(maxLength: 50, nullable: true),
                    Lastname = table.Column<string>(maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(maxLength: 10, nullable: true),
                    ProfilePictureFilePath = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    ClassName = table.Column<string>(maxLength: 20, nullable: true),
                    SchoolName = table.Column<string>(maxLength: 50, nullable: true),
                    FatherName = table.Column<string>(maxLength: 50, nullable: true),
                    MotherName = table.Column<string>(maxLength: 50, nullable: true),
                    FatherProfession = table.Column<string>(maxLength: 50, nullable: true),
                    MotherProfession = table.Column<string>(maxLength: 50, nullable: true),
                    FatherQualification = table.Column<string>(maxLength: 50, nullable: true),
                    MotherQualification = table.Column<string>(maxLength: 50, nullable: true),
                    FirstCareerId = table.Column<int>(nullable: true),
                    SecondCareerId = table.Column<int>(nullable: true),
                    ThirdCareerId = table.Column<int>(nullable: true),
                    FirstPassiveCareerId = table.Column<int>(nullable: true),
                    SecondPassiveCareerId = table.Column<int>(nullable: true),
                    ThirdPassiveCareerId = table.Column<int>(nullable: true),
                    IsPlanPurchased = table.Column<bool>(nullable: false, defaultValue: false),
                    LastTest = table.Column<string>(maxLength: 50, nullable: true),
                    PlanId = table.Column<int>(nullable: true),
                    PlanPurchaseDate = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    CodeSentOn = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    IscodeUsed = table.Column<bool>(nullable: true),
                    Subject1 = table.Column<string>(nullable: true),
                    Subject2 = table.Column<string>(nullable: true),
                    Subject3 = table.Column<string>(nullable: true),
                    Subject4 = table.Column<string>(nullable: true),
                    Subject5 = table.Column<string>(nullable: true),
                    DreamCareer1 = table.Column<string>(nullable: true),
                    DreamCareer2 = table.Column<string>(nullable: true),
                    WhatMotivatesYou = table.Column<string>(nullable: true),
                    InvitedByUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInformation_Careers_FirstCareerId",
                        column: x => x.FirstCareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserInformation_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserInformation_Careers_SecondCareerId",
                        column: x => x.SecondCareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserInformation_Careers_ThirdCareerId",
                        column: x => x.ThirdCareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserInformation_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    QuizID = table.Column<int>(nullable: false),
                    ImageID = table.Column<int>(nullable: true),
                    TimeDuration = table.Column<TimeSpan>(nullable: false),
                    HasOptionsDuration = table.Column<bool>(nullable: false),
                    OptionsTimeDuration = table.Column<TimeSpan>(nullable: false),
                    QuestionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizID",
                        column: x => x.QuizID,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentQuizzes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    QuizID = table.Column<int>(nullable: false),
                    StartedAt = table.Column<DateTime>(nullable: true),
                    CompletedAt = table.Column<DateTime>(nullable: true),
                    Score = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentQuizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentQuizzes_Quizzes_QuizID",
                        column: x => x.QuizID,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentQuizzes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentSlots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    SlotId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentSlots_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(nullable: true),
                    IsCorrect = table.Column<bool>(nullable: false),
                    ImageID = table.Column<int>(nullable: true),
                    QuestionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttemptedQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentQuizID = table.Column<int>(nullable: true),
                    QuestionID = table.Column<int>(nullable: false),
                    AnsweredAt = table.Column<DateTime>(nullable: true),
                    IsCorrect = table.Column<bool>(nullable: false),
                    Score = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttemptedQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttemptedQuestions_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttemptedQuestions_StudentQuizzes_StudentQuizID",
                        column: x => x.StudentQuizID,
                        principalTable: "StudentQuizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttemptedOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttemptedQuestionID = table.Column<int>(nullable: false),
                    OptionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttemptedOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttemptedOptions_AttemptedQuestions_AttemptedQuestionID",
                        column: x => x.AttemptedQuestionID,
                        principalTable: "AttemptedQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttemptedOptions_Options_OptionID",
                        column: x => x.OptionID,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptedOptions_AttemptedQuestionID",
                table: "AttemptedOptions",
                column: "AttemptedQuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptedOptions_OptionID",
                table: "AttemptedOptions",
                column: "OptionID");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptedQuestions_QuestionID",
                table: "AttemptedQuestions",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptedQuestions_StudentQuizID",
                table: "AttemptedQuestions",
                column: "StudentQuizID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_SubmittedByUserId",
                table: "Blogs",
                column: "SubmittedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CreatedByUserId",
                table: "Notifications",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_ImageID",
                table: "Options",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId",
                table: "Options",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ImageID",
                table: "Questions",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizID",
                table: "Questions",
                column: "QuizID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentModuleOneMarks_UserId",
                table: "StudentModuleOneMarks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQuizzes_QuizID",
                table: "StudentQuizzes",
                column: "QuizID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQuizzes_UserId",
                table: "StudentQuizzes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSlots_SlotId",
                table: "StudentSlots",
                column: "SlotId",
                unique: true,
                filter: "[SlotId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_FirstCareerId",
                table: "UserInformation",
                column: "FirstCareerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_PlanId",
                table: "UserInformation",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_SecondCareerId",
                table: "UserInformation",
                column: "SecondCareerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_ThirdCareerId",
                table: "UserInformation",
                column: "ThirdCareerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_UserId",
                table: "UserInformation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSibling_UserId",
                table: "UserSibling",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AttemptedOptions");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "InterestModuleQuestion6UserCareers");

            migrationBuilder.DropTable(
                name: "InterestModuleQuestion7UserCareers");

            migrationBuilder.DropTable(
                name: "InterestModuleQuestion8UserCareers");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OneTimePasswords");

            migrationBuilder.DropTable(
                name: "PassiveCareers");

            migrationBuilder.DropTable(
                name: "StudentModuleFiveMarks");

            migrationBuilder.DropTable(
                name: "StudentModuleFourMarks");

            migrationBuilder.DropTable(
                name: "StudentModuleOneMarks");

            migrationBuilder.DropTable(
                name: "StudentModuleThreeMarks");

            migrationBuilder.DropTable(
                name: "StudentModuleTwoMarks");

            migrationBuilder.DropTable(
                name: "StudentSlots");

            migrationBuilder.DropTable(
                name: "SystemInformation");

            migrationBuilder.DropTable(
                name: "UserInformation");

            migrationBuilder.DropTable(
                name: "UserSibling");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AttemptedQuestions");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "StudentQuizzes");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
