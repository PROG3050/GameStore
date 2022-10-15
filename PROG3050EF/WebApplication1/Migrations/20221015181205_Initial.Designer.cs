﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20221015181205_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryGame", b =>
                {
                    b.Property<int>("Categoryid")
                        .HasColumnType("int");

                    b.Property<int>("Gameid")
                        .HasColumnType("int");

                    b.HasKey("Categoryid", "Gameid");

                    b.ToTable("CategoryGame");
                });

            modelBuilder.Entity("CustomerEvent", b =>
                {
                    b.Property<int>("Customerid")
                        .HasColumnType("int");

                    b.Property<int>("Eventid")
                        .HasColumnType("int");

                    b.HasKey("Customerid", "Eventid")
                        .HasName("PK__Customer__333907D60F8269FF");

                    b.HasIndex("Eventid");

                    b.ToTable("Customer_Event", (string)null);
                });

            modelBuilder.Entity("GameCategory", b =>
                {
                    b.Property<int>("Gameid")
                        .HasColumnType("int");

                    b.Property<int>("Categoryid")
                        .HasColumnType("int");

                    b.HasKey("Gameid", "Categoryid")
                        .HasName("PK__Game_Cat__0B57EBB7A12BD34A");

                    b.HasIndex("Categoryid");

                    b.ToTable("Game_Category", (string)null);
                });

            modelBuilder.Entity("GameFeatureGame", b =>
                {
                    b.Property<int>("GameFeatureid")
                        .HasColumnType("int");

                    b.Property<int>("Gameid")
                        .HasColumnType("int");

                    b.HasKey("GameFeatureid", "Gameid")
                        .HasName("PK__GameFeat__0E2BBB9711BBC777");

                    b.HasIndex("Gameid");

                    b.ToTable("GameFeature_Game", (string)null);
                });

            modelBuilder.Entity("GameGameFeature", b =>
                {
                    b.Property<int>("GameFeatureid")
                        .HasColumnType("int");

                    b.Property<int>("Gameid")
                        .HasColumnType("int");

                    b.HasKey("GameFeatureid", "Gameid");

                    b.ToTable("GameGameFeature");
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.Property<int>("Gameid")
                        .HasColumnType("int");

                    b.Property<int>("Platformid")
                        .HasColumnType("int");

                    b.HasKey("Gameid", "Platformid");

                    b.ToTable("GamePlatform");
                });

            modelBuilder.Entity("PlatformGame", b =>
                {
                    b.Property<int>("Platformid")
                        .HasColumnType("int");

                    b.Property<int>("Gameid")
                        .HasColumnType("int");

                    b.HasKey("Platformid", "Gameid")
                        .HasName("PK__Platform__B7F882CFAE338AEA");

                    b.HasIndex("Gameid");

                    b.ToTable("Platform_Game", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Data.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebApplication1.Data.CreditCard", b =>
                {
                    b.Property<int>("CreditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("credit_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreditId"), 1L, 1);

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("cardName");

                    b.Property<int>("CardNumber")
                        .HasColumnType("int")
                        .HasColumnName("cardNumber");

                    b.Property<int>("CustId")
                        .HasColumnType("int")
                        .HasColumnName("cust_id");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime")
                        .HasColumnName("expirationDate");

                    b.HasKey("CreditId")
                        .HasName("PK__CreditCa__C15A9C36A58DE279");

                    b.HasIndex("CustId");

                    b.ToTable("CreditCard");
                });

            modelBuilder.Entity("WebApplication1.Data.Customer", b =>
                {
                    b.Property<int>("CustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cust_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustId"), 1L, 1);

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime")
                        .HasColumnName("dob");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("firstName");

                    b.Property<int?>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("lastName");

                    b.Property<string>("MailingAddress")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("mailingAddress");

                    b.Property<string>("MailingPostalCode")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("mailingPostalCode");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<int>("PreferedCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("preferedCategory_id");

                    b.Property<int>("PreferedPlatformId")
                        .HasColumnType("int")
                        .HasColumnName("preferedPlatform_id");

                    b.Property<bool?>("RecievePromotion")
                        .HasColumnType("bit")
                        .HasColumnName("recievePromotion");

                    b.Property<string>("ShippingAddress")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("shippingAddress");

                    b.Property<string>("ShippingPostalCode")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("shippingPostalCode");

                    b.HasKey("CustId")
                        .HasName("PK__Customer__A1B71F90C6489007");

                    b.HasIndex("PreferedCategoryId");

                    b.HasIndex("PreferedPlatformId");

                    b.HasIndex(new[] { "Email" }, "UQ__Customer__AB6E6164661522CF")
                        .IsUnique();

                    b.HasIndex(new[] { "Nickname" }, "UQ__Customer__CC6CD17E283CABFD")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("WebApplication1.Data.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("emp_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.HasKey("EmpId")
                        .HasName("PK__Employee__1299A861977CC9A6");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("WebApplication1.Data.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("event_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Duration")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("duration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.HasKey("EventId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("WebApplication1.Data.FriendsFamily", b =>
                {
                    b.Property<int>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("friend_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FriendId"), 1L, 1);

                    b.Property<int>("CustId1")
                        .HasColumnType("int")
                        .HasColumnName("cust_id1");

                    b.Property<int>("CustId2")
                        .HasColumnType("int")
                        .HasColumnName("cust_id2");

                    b.Property<DateTime>("DateConnected")
                        .HasColumnType("datetime")
                        .HasColumnName("dateConnected");

                    b.Property<bool>("IsFamily")
                        .HasColumnType("bit")
                        .HasColumnName("isFamily");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.HasKey("FriendId")
                        .HasName("PK__FriendsF__3FA1E155F831F53C");

                    b.HasIndex("CustId1");

                    b.HasIndex("CustId2");

                    b.ToTable("FriendsFamily");
                });

            modelBuilder.Entity("WebApplication1.Data.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<bool?>("Digital")
                        .HasColumnType("bit")
                        .HasColumnName("digital");

                    b.Property<int?>("Discount")
                        .HasColumnType("int")
                        .HasColumnName("discount");

                    b.Property<int?>("GameStudio")
                        .HasColumnType("int")
                        .HasColumnName("gameStudio");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<int?>("Pquantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(19,2)")
                        .HasColumnName("price");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime")
                        .HasColumnName("releaseDate");

                    b.HasKey("GameId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("WebApplication1.Data.GameFeature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("feature_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureId"), 1L, 1);

                    b.Property<string>("Feature")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("feature");

                    b.HasKey("FeatureId")
                        .HasName("PK__GameFeat__7906CBD7BF1F29A9");

                    b.ToTable("GameFeature");
                });

            modelBuilder.Entity("WebApplication1.Data.GameImage", b =>
                {
                    b.Property<int>("GameImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("gameImg_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameImgId"), 1L, 1);

                    b.Property<string>("Extention")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("extention");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<bool>("IsCoverImage")
                        .HasColumnType("bit")
                        .HasColumnName("isCoverImage");

                    b.Property<string>("Path")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("path");

                    b.HasKey("GameImgId")
                        .HasName("PK__GameImag__132575EA33968AE7");

                    b.HasIndex("GameId");

                    b.ToTable("GameImage");
                });

            modelBuilder.Entity("WebApplication1.Data.Merchandise", b =>
                {
                    b.Property<int>("MerchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("merch_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MerchId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<int?>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(19,2)")
                        .HasColumnName("price");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("MerchId")
                        .HasName("PK__Merchand__1937E9C0E88FCC6F");

                    b.ToTable("Merchandise");
                });

            modelBuilder.Entity("WebApplication1.Data.MerchandiseImage", b =>
                {
                    b.Property<int>("MerchImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("merchImg_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MerchImgId"), 1L, 1);

                    b.Property<string>("Extention")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("extention");

                    b.Property<int>("MerchandiseId")
                        .HasColumnType("int")
                        .HasColumnName("merchandise_id");

                    b.Property<string>("Path")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("path");

                    b.HasKey("MerchImgId")
                        .HasName("PK__Merchand__4D99D94A9EAE7002");

                    b.HasIndex("MerchandiseId");

                    b.ToTable("MerchandiseImage");
                });

            modelBuilder.Entity("WebApplication1.Data.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("CustId")
                        .HasColumnType("int")
                        .HasColumnName("cust_id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<bool>("IsShipped")
                        .HasColumnType("bit")
                        .HasColumnName("isShipped");

                    b.Property<int>("MerchandiseId")
                        .HasColumnType("int")
                        .HasColumnName("merchandise_id");

                    b.Property<string>("OrderNo")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("order_no");

                    b.HasKey("OrderId");

                    b.HasIndex("CustId");

                    b.HasIndex("GameId");

                    b.HasIndex("MerchandiseId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebApplication1.Data.Platform", b =>
                {
                    b.Property<int>("PlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("platform_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlatformId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.HasKey("PlatformId");

                    b.ToTable("Platform");
                });

            modelBuilder.Entity("WebApplication1.Data.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("review_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<int>("CustId")
                        .HasColumnType("int")
                        .HasColumnName("cust_id");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<int>("Rate")
                        .HasColumnType("int")
                        .HasColumnName("rate");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("title");

                    b.HasKey("ReviewId");

                    b.HasIndex("CustId");

                    b.HasIndex("GameId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("WebApplication1.Data.ReviewImage", b =>
                {
                    b.Property<int>("ReviewImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("reviewImg_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewImgId"), 1L, 1);

                    b.Property<string>("Extention")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("extention");

                    b.Property<string>("Path")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("path");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int")
                        .HasColumnName("review_id");

                    b.HasKey("ReviewImgId")
                        .HasName("PK__ReviewIm__ADCB53FF60CE66D7");

                    b.HasIndex("ReviewId");

                    b.ToTable("ReviewImage");
                });

            modelBuilder.Entity("WebApplication1.Data.WishList", b =>
                {
                    b.Property<int>("WishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("wish_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishId"), 1L, 1);

                    b.Property<int>("CustId")
                        .HasColumnType("int")
                        .HasColumnName("cust_id");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<int>("MerchandiseId")
                        .HasColumnType("int")
                        .HasColumnName("merchandise_id");

                    b.HasKey("WishId")
                        .HasName("PK__WishList__4F227CA0D99D4B73");

                    b.HasIndex("CustId");

                    b.HasIndex("GameId");

                    b.HasIndex("MerchandiseId");

                    b.ToTable("WishList");
                });

            modelBuilder.Entity("CustomerEvent", b =>
                {
                    b.HasOne("WebApplication1.Data.Customer", null)
                        .WithMany()
                        .HasForeignKey("Customerid")
                        .IsRequired()
                        .HasConstraintName("FKCustomer_E75975");

                    b.HasOne("WebApplication1.Data.Event", null)
                        .WithMany()
                        .HasForeignKey("Eventid")
                        .IsRequired()
                        .HasConstraintName("FKCustomer_E485607");
                });

            modelBuilder.Entity("GameCategory", b =>
                {
                    b.HasOne("WebApplication1.Data.Category", null)
                        .WithMany()
                        .HasForeignKey("Categoryid")
                        .IsRequired()
                        .HasConstraintName("FKGame_Categ786403");

                    b.HasOne("WebApplication1.Data.Game", null)
                        .WithMany()
                        .HasForeignKey("Gameid")
                        .IsRequired()
                        .HasConstraintName("FKGame_Categ26396");
                });

            modelBuilder.Entity("GameFeatureGame", b =>
                {
                    b.HasOne("WebApplication1.Data.GameFeature", null)
                        .WithMany()
                        .HasForeignKey("GameFeatureid")
                        .IsRequired()
                        .HasConstraintName("FKGameFeatur415415");

                    b.HasOne("WebApplication1.Data.Game", null)
                        .WithMany()
                        .HasForeignKey("Gameid")
                        .IsRequired()
                        .HasConstraintName("FKGameFeatur387831");
                });

            modelBuilder.Entity("PlatformGame", b =>
                {
                    b.HasOne("WebApplication1.Data.Game", null)
                        .WithMany()
                        .HasForeignKey("Gameid")
                        .IsRequired()
                        .HasConstraintName("FKPlatform_G103358");

                    b.HasOne("WebApplication1.Data.Platform", null)
                        .WithMany()
                        .HasForeignKey("Platformid")
                        .IsRequired()
                        .HasConstraintName("FKPlatform_G477683");
                });

            modelBuilder.Entity("WebApplication1.Data.CreditCard", b =>
                {
                    b.HasOne("WebApplication1.Data.Customer", "Cust")
                        .WithMany("CreditCards")
                        .HasForeignKey("CustId")
                        .IsRequired()
                        .HasConstraintName("FKCreditCard326673");

                    b.Navigation("Cust");
                });

            modelBuilder.Entity("WebApplication1.Data.Customer", b =>
                {
                    b.HasOne("WebApplication1.Data.Category", "PreferedCategory")
                        .WithMany("Customers")
                        .HasForeignKey("PreferedCategoryId")
                        .IsRequired()
                        .HasConstraintName("FKCustomer578024");

                    b.HasOne("WebApplication1.Data.Platform", "PreferedPlatform")
                        .WithMany("Customers")
                        .HasForeignKey("PreferedPlatformId")
                        .IsRequired()
                        .HasConstraintName("FKCustomer55737");

                    b.Navigation("PreferedCategory");

                    b.Navigation("PreferedPlatform");
                });

            modelBuilder.Entity("WebApplication1.Data.FriendsFamily", b =>
                {
                    b.HasOne("WebApplication1.Data.Customer", "CustId1Navigation")
                        .WithMany("FriendsFamilyCustId1Navigations")
                        .HasForeignKey("CustId1")
                        .IsRequired()
                        .HasConstraintName("FKFriendsFam820474");

                    b.HasOne("WebApplication1.Data.Customer", "CustId2Navigation")
                        .WithMany("FriendsFamilyCustId2Navigations")
                        .HasForeignKey("CustId2")
                        .IsRequired()
                        .HasConstraintName("FKFriendsFam820475");

                    b.Navigation("CustId1Navigation");

                    b.Navigation("CustId2Navigation");
                });

            modelBuilder.Entity("WebApplication1.Data.GameImage", b =>
                {
                    b.HasOne("WebApplication1.Data.Game", "Game")
                        .WithMany("GameImages")
                        .HasForeignKey("GameId")
                        .IsRequired()
                        .HasConstraintName("FKGameImage381528");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("WebApplication1.Data.MerchandiseImage", b =>
                {
                    b.HasOne("WebApplication1.Data.Merchandise", "Merchandise")
                        .WithMany("MerchandiseImages")
                        .HasForeignKey("MerchandiseId")
                        .IsRequired()
                        .HasConstraintName("FKMerchandis483326");

                    b.Navigation("Merchandise");
                });

            modelBuilder.Entity("WebApplication1.Data.Order", b =>
                {
                    b.HasOne("WebApplication1.Data.Customer", "Cust")
                        .WithMany("Orders")
                        .HasForeignKey("CustId")
                        .IsRequired()
                        .HasConstraintName("FKOrder861201");

                    b.HasOne("WebApplication1.Data.Game", "Game")
                        .WithMany("Orders")
                        .HasForeignKey("GameId")
                        .IsRequired()
                        .HasConstraintName("FKOrder547560");

                    b.HasOne("WebApplication1.Data.Merchandise", "Merchandise")
                        .WithMany("Orders")
                        .HasForeignKey("MerchandiseId")
                        .IsRequired()
                        .HasConstraintName("FKOrder609133");

                    b.Navigation("Cust");

                    b.Navigation("Game");

                    b.Navigation("Merchandise");
                });

            modelBuilder.Entity("WebApplication1.Data.Review", b =>
                {
                    b.HasOne("WebApplication1.Data.Customer", "Cust")
                        .WithMany("Reviews")
                        .HasForeignKey("CustId")
                        .IsRequired()
                        .HasConstraintName("FKReview172984");

                    b.HasOne("WebApplication1.Data.Game", "Game")
                        .WithMany("Reviews")
                        .HasForeignKey("GameId")
                        .IsRequired()
                        .HasConstraintName("FKReview486625");

                    b.Navigation("Cust");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("WebApplication1.Data.ReviewImage", b =>
                {
                    b.HasOne("WebApplication1.Data.Review", "Review")
                        .WithMany("ReviewImages")
                        .HasForeignKey("ReviewId")
                        .IsRequired()
                        .HasConstraintName("FKReviewImag856029");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("WebApplication1.Data.WishList", b =>
                {
                    b.HasOne("WebApplication1.Data.Customer", "Cust")
                        .WithMany("WishLists")
                        .HasForeignKey("CustId")
                        .IsRequired()
                        .HasConstraintName("FKWishList705462");

                    b.HasOne("WebApplication1.Data.Game", "Game")
                        .WithMany("WishLists")
                        .HasForeignKey("GameId")
                        .IsRequired()
                        .HasConstraintName("FKWishList952486");

                    b.HasOne("WebApplication1.Data.Merchandise", "Merchandise")
                        .WithMany("WishLists")
                        .HasForeignKey("MerchandiseId")
                        .IsRequired()
                        .HasConstraintName("FKWishList795792");

                    b.Navigation("Cust");

                    b.Navigation("Game");

                    b.Navigation("Merchandise");
                });

            modelBuilder.Entity("WebApplication1.Data.Category", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("WebApplication1.Data.Customer", b =>
                {
                    b.Navigation("CreditCards");

                    b.Navigation("FriendsFamilyCustId1Navigations");

                    b.Navigation("FriendsFamilyCustId2Navigations");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("WebApplication1.Data.Game", b =>
                {
                    b.Navigation("GameImages");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("WebApplication1.Data.Merchandise", b =>
                {
                    b.Navigation("MerchandiseImages");

                    b.Navigation("Orders");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("WebApplication1.Data.Platform", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("WebApplication1.Data.Review", b =>
                {
                    b.Navigation("ReviewImages");
                });
#pragma warning restore 612, 618
        }
    }
}
