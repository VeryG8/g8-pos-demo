# G8 POS Demo Deployment Notes

## 目標
把目前的 Blazor POS Demo 整理成可部署到外網的平台，供平板或手機遠端試用。

## 目前狀態
專案已可：
- `dotnet build`
- `dotnet run`
- `dotnet publish`

## 最適合的近期部署定位
- **外網 Demo / MVP 驗證站**
- 不建議當正式營運 POS

## 建議部署平台
### 1. Azure App Service
優點：
- 跟 ASP.NET Core / .NET 很搭
- 後續若要變正式架構，延展性較好

### 2. Render
優點：
- MVP / Demo 佈署快
- 外網試用方便

### 3. Railway
優點：
- 建立 demo 很快
- 適合快速試用

## 基本 publish 指令
```powershell
dotnet publish .\POS\src\G8.PosDemo.Web\G8.PosDemo.Web.csproj -c Release -o .\POS\publish\G8.PosDemo.Web
```

## 平台部署需求
大多數平台至少需要：
- .NET 8 runtime
- 指定啟動命令或自動偵測 ASP.NET Core
- 開放 HTTP / HTTPS 入口

## Demo 部署前建議確認
1. 首頁與互動流程在桌機可正常運作
2. 平板尺寸下版面可接受
3. 不把這個版本當正式收銀系統
4. 不放任何真實敏感營運資料

## 目前不建議直接正式上線的原因
- 還沒有登入/權限控管
- 還沒有正式資料庫與資料持久化
- 還沒有支付 / 發票 / 列印硬體整合
- 還在快速調整 UI / 操作流程階段

## 建議近期路線
### Phase A：外網 demo
- 讓平板可遠端打開
- 收集 UI / UX feedback

### Phase B：資料模型化
- Product / Order / OrderItem / Customer
- 假資料抽 service

### Phase C：正式化
- PostgreSQL
- Auth
- 實際結帳流程
- 店內 Bridge Agent
