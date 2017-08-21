﻿using Orchard.Data.Migration;

namespace PJS.Bootstrap {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("ThemeSettingsRecord", table => table
                .Column<int>("Id", column => column.PrimaryKey().Identity())
                .Column<string>("Swatch", c => c.WithLength(50).WithDefault(Constants.SwatchCssDefault))
                .Column<bool>("UseFixedNav")
                .Column<bool>("UseNavSearch")
                .Column<bool>("UseFluidLayout")
                .Column<bool>("UseInverseNav")
                .Column<bool>("UseStickyFooter")
            );

            return 1;
        }

        public int UpdateFrom1() {
            SchemaBuilder.AlterTable("ThemeSettingsRecord", table =>
                table.AddColumn<int>("BlogPostLayout"));

            return 2;
        }

        public int UpdateFrom2() {
            SchemaBuilder.AlterTable("ThemeSettingsRecord", table =>
                table.AddColumn<int>("UseHoverMenu"));

            return 3;
        }
    }
}