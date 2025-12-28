using System;
using System.Collections.Generic;

public static class AuctionData
{
    public static List<Auction> GetAll()
    {
        return new List<Auction>
        {
            // 1. Graphics Card
            new Auction { Id = Guid.NewGuid(), ReservePrice = 1600, AuctionEnd = DateTime.UtcNow.AddDays(7),
                Item = new Item { Make = "NVIDIA", Model = "GeForce RTX 4090 Founders Edition", Color = "Gunmetal", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1591488320449-011701bb6704?auto=format&fit=crop&w=800&q=80" } },
            // 2. CPU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 550, AuctionEnd = DateTime.UtcNow.AddDays(3),
                Item = new Item { Make = "Intel", Model = "Core i9-14900K", Color = "Silver", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1555618568-8761b62f887b?auto=format&fit=crop&w=800&q=80" } },
            // 3. Motherboard
            new Auction { Id = Guid.NewGuid(), ReservePrice = 400, AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item { Make = "MSI", Model = "MPG Z790 Carbon WiFi", Color = "Black", Mileage = 10, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1518770660439-4636190af475?auto=format&fit=crop&w=800&q=80" } },
            // 4. RAM
            new Auction { Id = Guid.NewGuid(), ReservePrice = 180, AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item { Make = "G.Skill", Model = "Trident Z5 RGB 32GB DDR5", Color = "Silver", Mileage = 0, Year = 2024, ImageUrl = "https://images.unsplash.com/photo-1562976540-1502c2145186?auto=format&fit=crop&w=800&q=80" } },
            // 5. Storage
            new Auction { Id = Guid.NewGuid(), ReservePrice = 120, AuctionEnd = DateTime.UtcNow.AddDays(2),
                Item = new Item { Make = "Samsung", Model = "990 PRO 2TB NVMe", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1591799264318-7e6ef8ddb7ea?auto=format&fit=crop&w=800&q=80" } },
            // 6. Case
            new Auction { Id = Guid.NewGuid(), ReservePrice = 150, AuctionEnd = DateTime.UtcNow.AddDays(6),
                Item = new Item { Make = "Lian Li", Model = "O11 Dynamic Evo", Color = "White", Mileage = 50, Year = 2022, ImageUrl = "https://images.unsplash.com/photo-1587202372775-e229f172b9d7?auto=format&fit=crop&w=800&q=80" } },
            // 7. PSU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 200, AuctionEnd = DateTime.UtcNow.AddDays(5),
                Item = new Item { Make = "Corsair", Model = "RM1000x Shift", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1587202372634-32705e3bf49c?auto=format&fit=crop&w=800&q=80" } },
            // 8. GPU (AMD)
            new Auction { Id = Guid.NewGuid(), ReservePrice = 900, AuctionEnd = DateTime.UtcNow.AddDays(8),
                Item = new Item { Make = "Sapphire", Model = "Radeon RX 7900 XTX Nitro+", Color = "Silver/Black", Mileage = 10, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1591488320449-011701bb6704?auto=format&fit=crop&w=800&q=80" } },
            // 9. CPU (AMD)
            new Auction { Id = Guid.NewGuid(), ReservePrice = 400, AuctionEnd = DateTime.UtcNow.AddDays(1),
                Item = new Item { Make = "AMD", Model = "Ryzen 7 7800X3D", Color = "Silver", Mileage = 100, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1555618568-8761b62f887b?auto=format&fit=crop&w=800&q=80" } },
            // 10. Cooler
            new Auction { Id = Guid.NewGuid(), ReservePrice = 250, AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item { Make = "NZXT", Model = "Kraken Elite 360 RGB", Color = "White", Mileage = 0, Year = 2024, ImageUrl = "https://images.unsplash.com/photo-1587202372634-32705e3bf49c?auto=format&fit=crop&w=800&q=80" } },
            // 11. Motherboard
            new Auction { Id = Guid.NewGuid(), ReservePrice = 600, AuctionEnd = DateTime.UtcNow.AddDays(9),
                Item = new Item { Make = "ASUS", Model = "ROG Crosshair X670E Hero", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1518770660439-4636190af475?auto=format&fit=crop&w=800&q=80" } },
            // 12. GPU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 1100, AuctionEnd = DateTime.UtcNow.AddDays(3),
                Item = new Item { Make = "Gigabyte", Model = "GeForce RTX 4080 Super Aero", Color = "White", Mileage = 0, Year = 2024, ImageUrl = "https://images.unsplash.com/photo-1550745165-9bc0b252726f?auto=format&fit=crop&w=800&q=80" } },
            // 13. Keyboard
            new Auction { Id = Guid.NewGuid(), ReservePrice = 180, AuctionEnd = DateTime.UtcNow.AddDays(5),
                Item = new Item { Make = "Razer", Model = "BlackWidow V4 Pro", Color = "Black", Mileage = 10, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212?auto=format&fit=crop&w=800&q=80" } },
            // 14. Mouse
            new Auction { Id = Guid.NewGuid(), ReservePrice = 130, AuctionEnd = DateTime.UtcNow.AddDays(2),
                Item = new Item { Make = "Logitech", Model = "G Pro X Superlight 2", Color = "Pink", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1527814050087-3793815479db?auto=format&fit=crop&w=800&q=80" } },
            // 15. Monitor
            new Auction { Id = Guid.NewGuid(), ReservePrice = 900, AuctionEnd = DateTime.UtcNow.AddDays(6),
                Item = new Item { Make = "Alienware", Model = "AW3423DWF QD-OLED", Color = "Black", Mileage = 200, Year = 2022, ImageUrl = "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?auto=format&fit=crop&w=800&q=80" } },
            // 16. Case
            new Auction { Id = Guid.NewGuid(), ReservePrice = 180, AuctionEnd = DateTime.UtcNow.AddDays(7),
                Item = new Item { Make = "Hyte", Model = "Y60", Color = "Red", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1587202372775-e229f172b9d7?auto=format&fit=crop&w=800&q=80" } },
            // 17. RAM
            new Auction { Id = Guid.NewGuid(), ReservePrice = 120, AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item { Make = "Corsair", Model = "Vengeance RGB 32GB", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1562976540-1502c2145186?auto=format&fit=crop&w=800&q=80" } },
            // 18. Storage
            new Auction { Id = Guid.NewGuid(), ReservePrice = 80, AuctionEnd = DateTime.UtcNow.AddDays(3),
                Item = new Item { Make = "Western Digital", Model = "WD Black SN850X 1TB", Color = "Black", Mileage = 10, Year = 2022, ImageUrl = "https://images.unsplash.com/photo-1591799264318-7e6ef8ddb7ea?auto=format&fit=crop&w=800&q=80" } },
            // 19. Fans
            new Auction { Id = Guid.NewGuid(), ReservePrice = 90, AuctionEnd = DateTime.UtcNow.AddDays(2),
                Item = new Item { Make = "Lian Li", Model = "Uni Fan SL-Infinity (3-Pack)", Color = "White", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1587202372634-32705e3bf49c?auto=format&fit=crop&w=800&q=80" } },
            // 20. GPU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 300, AuctionEnd = DateTime.UtcNow.AddDays(5),
                Item = new Item { Make = "ASUS", Model = "Dual GeForce RTX 4060", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1591488320449-011701bb6704?auto=format&fit=crop&w=800&q=80" } },
            // 21. CPU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 280, AuctionEnd = DateTime.UtcNow.AddDays(8),
                Item = new Item { Make = "Intel", Model = "Core i5-13600K", Color = "Silver", Mileage = 0, Year = 2022, ImageUrl = "https://images.unsplash.com/photo-1555618568-8761b62f887b?auto=format&fit=crop&w=800&q=80" } },
            // 22. PSU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 140, AuctionEnd = DateTime.UtcNow.AddDays(3),
                Item = new Item { Make = "Seasonic", Model = "Vertex GX-1000", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1587202372634-32705e3bf49c?auto=format&fit=crop&w=800&q=80" } },
            // 23. Motherboard
            new Auction { Id = Guid.NewGuid(), ReservePrice = 220, AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item { Make = "Gigabyte", Model = "B650 Aorus Elite AX", Color = "Black", Mileage = 10, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1518770660439-4636190af475?auto=format&fit=crop&w=800&q=80" } },
            // 24. Audio Interface
            new Auction { Id = Guid.NewGuid(), ReservePrice = 150, AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item { Make = "Focusrite", Model = "Scarlett 2i2 4th Gen", Color = "Red", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212?auto=format&fit=crop&w=800&q=80" } },
            // 25. Case
            new Auction { Id = Guid.NewGuid(), ReservePrice = 100, AuctionEnd = DateTime.UtcNow.AddDays(2),
                Item = new Item { Make = "Fractal Design", Model = "North", Color = "Charcoal/Walnut", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1587202372775-e229f172b9d7?auto=format&fit=crop&w=800&q=80" } },
            // 26. Microphone
            new Auction { Id = Guid.NewGuid(), ReservePrice = 350, AuctionEnd = DateTime.UtcNow.AddDays(7),
                Item = new Item { Make = "Shure", Model = "SM7B", Color = "Black", Mileage = 50, Year = 2021, ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212?auto=format&fit=crop&w=800&q=80" } },
            // 27. GPU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 800, AuctionEnd = DateTime.UtcNow.AddDays(3),
                Item = new Item { Make = "MSI", Model = "GeForce RTX 4070 Ti Gaming X", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1591488320449-011701bb6704?auto=format&fit=crop&w=800&q=80" } },
            // 28. Monitor
            new Auction { Id = Guid.NewGuid(), ReservePrice = 1200, AuctionEnd = DateTime.UtcNow.AddDays(5),
                Item = new Item { Make = "Samsung", Model = "Odyssey Neo G9", Color = "White", Mileage = 10, Year = 2022, ImageUrl = "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?auto=format&fit=crop&w=800&q=80" } },
            // 29. Headset
            new Auction { Id = Guid.NewGuid(), ReservePrice = 250, AuctionEnd = DateTime.UtcNow.AddDays(1),
                Item = new Item { Make = "SteelSeries", Model = "Arctis Nova Pro Wireless", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212?auto=format&fit=crop&w=800&q=80" } },
            // 30. Cooler
            new Auction { Id = Guid.NewGuid(), ReservePrice = 100, AuctionEnd = DateTime.UtcNow.AddDays(6),
                Item = new Item { Make = "Noctua", Model = "NH-D15 Chromax.Black", Color = "Black", Mileage = 20, Year = 2021, ImageUrl = "https://images.unsplash.com/photo-1587202372634-32705e3bf49c?auto=format&fit=crop&w=800&q=80" } },
            // 31. CPU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 500, AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item { Make = "AMD", Model = "Ryzen 9 7950X", Color = "Silver", Mileage = 0, Year = 2022, ImageUrl = "https://images.unsplash.com/photo-1555618568-8761b62f887b?auto=format&fit=crop&w=800&q=80" } },
            // 32. RAM
            new Auction { Id = Guid.NewGuid(), ReservePrice = 80, AuctionEnd = DateTime.UtcNow.AddDays(2),
                Item = new Item { Make = "TeamGroup", Model = "T-Force Delta RGB 32GB", Color = "White", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1562976540-1502c2145186?auto=format&fit=crop&w=800&q=80" } },
            // 33. Storage
            new Auction { Id = Guid.NewGuid(), ReservePrice = 180, AuctionEnd = DateTime.UtcNow.AddDays(8),
                Item = new Item { Make = "Crucial", Model = "T700 2TB Gen5 NVMe", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1591799264318-7e6ef8ddb7ea?auto=format&fit=crop&w=800&q=80" } },
            // 34. Motherboard
            new Auction { Id = Guid.NewGuid(), ReservePrice = 280, AuctionEnd = DateTime.UtcNow.AddDays(3),
                Item = new Item { Make = "ASRock", Model = "X670E Taichi", Color = "Gold/Black", Mileage = 10, Year = 2022, ImageUrl = "https://images.unsplash.com/photo-1518770660439-4636190af475?auto=format&fit=crop&w=800&q=80" } },
            // 35. Webcam
            new Auction { Id = Guid.NewGuid(), ReservePrice = 250, AuctionEnd = DateTime.UtcNow.AddDays(5),
                Item = new Item { Make = "Elgato", Model = "Facecam Pro", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1527814050087-3793815479db?auto=format&fit=crop&w=800&q=80" } },
            // 36. Controller
            new Auction { Id = Guid.NewGuid(), ReservePrice = 180, AuctionEnd = DateTime.UtcNow.AddDays(1),
                Item = new Item { Make = "Microsoft", Model = "Xbox Elite Series 2 Core", Color = "White", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212?auto=format&fit=crop&w=800&q=80" } },
            // 37. VR Headset
            new Auction { Id = Guid.NewGuid(), ReservePrice = 450, AuctionEnd = DateTime.UtcNow.AddDays(9),
                Item = new Item { Make = "Meta", Model = "Quest 3 512GB", Color = "White", Mileage = 5, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212?auto=format&fit=crop&w=800&q=80" } },
            // 38. GPU
            new Auction { Id = Guid.NewGuid(), ReservePrice = 500, AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item { Make = "AMD", Model = "Radeon RX 7800 XT", Color = "Black", Mileage = 0, Year = 2023, ImageUrl = "https://images.unsplash.com/photo-1591488320449-011701bb6704?auto=format&fit=crop&w=800&q=80" } },
            // 39. Chair
            new Auction { Id = Guid.NewGuid(), ReservePrice = 1200, AuctionEnd = DateTime.UtcNow.AddDays(14),
                Item = new Item { Make = "Herman Miller", Model = "Embody Gaming Chair", Color = "Cyan/Black", Mileage = 0, Year = 2022, ImageUrl = "https://images.unsplash.com/photo-1587202372775-e229f172b9d7?auto=format&fit=crop&w=800&q=80" } },
            // 40. Laptop (Gaming)
            new Auction { Id = Guid.NewGuid(), ReservePrice = 2500, AuctionEnd = DateTime.UtcNow.AddDays(6),
                Item = new Item { Make = "Razer", Model = "Blade 16", Color = "Black", Mileage = 10, Year = 2024, ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212?auto=format&fit=crop&w=800&q=80" } }
        };
    }
}

public class Auction {
    public Guid Id { get; set; }
    public decimal ReservePrice { get; set; }
    public DateTime AuctionEnd { get; set; }
    public Item Item { get; set; }
}
public class Item {
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public int Year { get; set; }
    public string ImageUrl { get; set; }
}