﻿using Hexa.Business.Models.Pictures;
using Hexa.Business.Models.Shared;

namespace Hexa.Business.Models.Catalog
{
    public class CategoryModel : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int PictureId { get; set; }

        public int ParentCategoryId { get; set; }

        public bool IncludeInNavigation { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public int DisplayOrder { get; set; }

        public PictureModel Picture { get; set; }
    }
}
